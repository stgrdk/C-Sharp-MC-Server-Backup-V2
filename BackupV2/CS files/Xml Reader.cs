﻿using System;
using System.Xml;

namespace BackupV2
{
    public class Xml_Reader
    {
        XmlDocument xd = new XmlDocument();
        XmlNode node1, node2, node3, node4, node5, node6, node7, node8, node9, node10;

        #region get user settings from XML file

        public string GetWorld()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node1 = xd.SelectSingleNode("descendant::*[name(.) = 'worldFrom']");
            return node1.InnerText.ToString();
        }

        public string GetBackupTo()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node2 = xd.SelectSingleNode("descendant::*[name(.) = 'worldTo']");
            return node2.InnerText.ToString();
        }

        public string GetFtpUser()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node3 = xd.SelectSingleNode("descendant::*[name(.) = 'ftpUser']");
            return node3.InnerText.ToString();
        }

        public string GetFtpPass()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node4 = xd.SelectSingleNode("descendant::*[name(.) = 'ftpPass']");
            return node4.InnerText.ToString();
        }

        public string GetFtpServer()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node5 = xd.SelectSingleNode("descendant::*[name(.) = 'ftpServer']");
            return node5.InnerText.ToString();
        }

        public string UseCompression()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node6 = xd.SelectSingleNode("descendant::*[name(.) = 'compression']");
            return node6.InnerText.ToString();
        }

        public string GetFtpFolder()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node7 = xd.SelectSingleNode("descendant::*[name(.) = 'ftpFolder']");
            return node7.InnerText.ToString();
        }

        public string GetFtpFolder2()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node8 = xd.SelectSingleNode("descendant::*[name(.) =  'ftpFolder2']");
            return node8.InnerText.ToString();
        }

        public string GetBackupTime()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node9 = xd.SelectSingleNode("descendant::*[name(.) = 'timeBetween']");
            return node9.InnerText.ToString();
        }

        public string GetUpdateSettings()
        {
            xd.Load(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Settings.config");
            node10 = xd.SelectSingleNode("descendant::*[name(.) = 'Update']");
            return node10.InnerText.ToString();
        }

        #endregion
    }
}