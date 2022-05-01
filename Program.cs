// See https://aka.ms/new-console-template for more information
using System;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

//Input data
Console.Write("From: ");
var from = Console.ReadLine();

Console.Write("To: ");
var to = Console.ReadLine();

Console.WriteLine("Enter subject:");
var subject = Console.ReadLine();

Console.WriteLine("Enter body:");
var body = Console.ReadLine();

//Create email
var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse(from));
email.To.Add(MailboxAddress.Parse(to));
email.Subject = subject;
email.Body = new TextPart(TextFormat.Plain) { Text = body };

// send email
using var smtp = new SmtpClient();
smtp.Connect("localhost", 25);
smtp.Send(email);
smtp.Disconnect(true);


