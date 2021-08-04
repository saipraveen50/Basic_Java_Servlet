package com.java.servlet.basics;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletConfig;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class LoginServlet
 */
@WebServlet("/loginServlet")
public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private Connection connection;

	public void init(ServletConfig config) {
		try {
			ServletContext context = config.getServletContext();
			Class.forName("com.mysql.jdbc.Driver");
			connection = DriverManager.getConnection(context.getInitParameter("dbUrl"),
					context.getInitParameter("dbUser"), context.getInitParameter("dbPassword"));
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String email = request.getParameter("email");
		String password = request.getParameter("password");

		try {
			Statement statement = connection.createStatement();
			ResultSet resultSet = statement
					.executeQuery("select * from user where email='" + email + "' and password='" + password + "'");
			RequestDispatcher requestDispatcher = request.getRequestDispatcher("homeServlet");
			response.setContentType("text/html");
			PrintWriter out = response.getWriter();
			if (resultSet.next()) {
				request.setAttribute("message", "Welcome to Interservlet Communication " + resultSet.getString(1) + " "
						+ resultSet.getString(2));
				requestDispatcher.forward(request, response);
			} else {
				out.print("<p style='color:red; font-size:larger'>Invalid Email Id or Password!</p>");
				requestDispatcher = request.getRequestDispatcher("login.html");
				requestDispatcher.include(request, response);

			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

}
