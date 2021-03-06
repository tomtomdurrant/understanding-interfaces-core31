﻿using PersonReader.CSV;
using PersonReader.Interface;
using PersonReader.Service;
using PersonReader.SQL;
using System;

namespace PeopleViewer
{
    public static class ReaderFactory
    {
        public static IPersonReader GetReader(string readerType)
        {
            IPersonReader reader;

            switch (readerType)
            {
                case "Service":
                    reader = new ServiceReader();
                    break;
                case "CSV":
                    reader = new CSVReader();
                    break;
                case "SQL":
                    reader = new SQLReader();
                    break;
                default:
                    throw new ArgumentException("Invalid reader type");
            }

            return reader;
        }
    }
}
