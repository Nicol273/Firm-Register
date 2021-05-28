/*
 * Created by SharpDevelop.
 * User: mega
 * Date: 27.5.2021 г.
 * Time: 17:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BulStatRegister
{
	public class BulStat
	{
		Dictionary<string, string> companies;
		public BulStat()
		{
			companies = new Dictionary<string, string>(100)
			{
					{ "100000000", "Алвас АД" },
					{ "100000001", "Призком АД" },
					{ "100000002", "Сириус ООД"},
					{ "100000003", "Мегатур АД" },
					{ "100000004", "Елина ЕООД" }
			};
		}
		public void PrintCompaniesCount()
		{
			Console.WriteLine("Брой фирми в регистъра: {0}", companies.Count);
		}
		public void ShowCompanies()
		{
			Console.WriteLine("Регистър на фирмите:");
			if(companies.Count != 0)
			{
				foreach(KeyValuePair<string,string> bulstatName in companies)
				{
					Console.WriteLine("{0} - {1}", bulstatName.Key, bulstatName.Value);
				}
				PrintCompaniesCount();
			}
			else Console.WriteLine("Регистърът е празен.");
		}
		public void AddCompany()
		{
			Console.WriteLine("Добавяне на фирма");
			Console.WriteLine(new String('-',50));
			string bulStat, firmName;
			Console.Write("Въведете БУЛСТАТ на фирмата: ");
			bulStat = Console.ReadLine();
			if(bulStat == null) 
			{
				Console.WriteLine("Не сте въвели БУЛСТАТ!");
				return;
			}
			if(bulStat.Length != 9)
			{
				Console.WriteLine("Невалидна дължина на БУЛСТАТ!");
				return;
			}
			Console.WriteLine("Въведете име на фирмата: ");
			firmName = Console.ReadLine();
			if(firmName == null)
			{
				Console.WriteLine("Не сте въвели име на фирмата!");
				return;
			}
			if(companies.ContainsKey(bulStat)) Console.WriteLine("Фирма с БУЛСТАТ {0} вече е регистрирана!", bulStat);
			else if(companies.ContainsValue(firmName)) Console.WriteLine("Името '{0}' вече е запазено в регистъра!", firmName);
			else 
			{
				companies.Add(bulStat,firmName);
				Console.WriteLine("Добавихте фирма '{0}' с БУЛСТАТ {1}", firmName, bulStat);
			}
			PrintCompaniesCount();
		}
		public void SearchItemByBS()
		{
			Console.WriteLine("Търсене на фирма по БУЛСТАТ");
			Console.WriteLine(new String('-',50));
			Console.Write("Въведете БУЛСТАТ на фирма: ");
			string bulStat = Console.ReadLine();
			if(companies.ContainsKey(bulStat)) Console.WriteLine("БУЛСТАТ: {0} - фирма: {1}", bulStat, companies[bulStat]);
			else Console.WriteLine("Фирма с БУЛСТАТ {0} не съществува в регистъра", bulStat);
		}
		public void SearchItemByCompany()
		{
			Console.WriteLine("Търсене на фирма по пълно име");
			Console.WriteLine(new String('-',50));
			Console.Write("Въведете име на фирма: ");
			string firmName = Console.ReadLine();
			if(!companies.ContainsValue(firmName)) Console.WriteLine("Фирма с име {0} не съществува в регистъра", firmName);
			else
			{
				foreach(KeyValuePair<string,string> bulstatName in companies)
				{
					if(companies.ContainsValue(firmName)) Console.WriteLine("БУЛСТАТ: {0} - фирма: {1}", bulstatName.Key, firmName);
				}
			}
		}
		public void SearchItemByPart()
		{
			Console.WriteLine("Търсене на фирма по част от име");
			Console.WriteLine(new String('-',50));
			Console.Write("Въведете име на фирма: ");
			string firmNamePart = Console.ReadLine();
			
		}
		public void RemoveCompany()
		{
			Console.WriteLine("Изтриване на фирма");
			Console.WriteLine(new String('-',50));
			Console.Write("Въведете БУЛСТАТ на фирма: ");
			string bulStat = Console.ReadLine();
			
		}
	}
}