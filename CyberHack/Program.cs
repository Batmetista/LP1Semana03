public enum HackTool
{
    BruteForce,
    Phishing,
    Backdoor,
    ZeroDay,
    AIOverride,
    QuantumExpoit
}
public enum SystemType
{
    CorporateServer,
    BankDatabase,
    SmartCityCore,
    MilitaryAI
}
public class Program
{
    private static void Main(string[] args)
    {
        SystemType System;
        HackTool Tool1;
        HackTool Tool2;

        string S =Console.ReadLine();

        if (S == "CorporateServer")
        {
            System = SystemType.CorporateServer;
        }
        if (S == "BankDataBase")
        {
            System = SystemType.BankDatabase;
        }
        if (S == "SmartCityCore")
        {
            System = SystemType.SmartCityCore;
        }
        if (S == "MilitaryAI")
        {
            System = SystemType.MilitaryAI;
        }
        
        string t1 = Console.ReadLine();

        if (t1 == "BruteForce")
        {
            Tool1 = HackTool.BruteForce;
        }
        if (t1 == "Phishing")
        {
            Tool1 = HackTool.Phishing;
        }
        if (t1 == "Backdoor")
        {
            Tool1 = HackTool.Backdoor;
        }
        if (t1 == "ZeroDay")
        {
            Tool1 = HackTool.ZeroDay;
        }
        if (t1 == "AIOverride")
        {
            Tool1 = HackTool.AIOverride;
        }
        if (t1 == "QuantumExpoit")
        {
            Tool1 = HackTool.QuantumExpoit;
        }

        string t2 = Console.ReadLine();

        if (t2 == "BruteForce")
        {
            Tool2 = HackTool.BruteForce;
        }
        if (t2 == "Phishing")
        {
            Tool2 = HackTool.Phishing;
        }
        if (t2 == "Backdoor")
        {
            Tool2 = HackTool.Backdoor;
        }
        if (t2 == "ZeroDay")
        {
            Tool2 = HackTool.ZeroDay;
        }
        if (t2 == "AIOverride")
        {
            Tool2 = HackTool.AIOverride;
        }
        if (t2 == "QuantumExpoit")
        {
            Tool2 = HackTool.QuantumExpoit;
        }
        
    }
}
