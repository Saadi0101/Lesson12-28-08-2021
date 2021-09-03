using System;
using System.Collections;
using System.ComponentModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keys: prokey or expkey");
            Console.WriteLine("Введите ключ:");
            string key = Console.ReadLine(); 
            
            if (key == "prokey")
            {
                Console.WriteLine("Вам доступно PRO версия!");
                ProDocumentWorker pro = new ProDocumentWorker();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if (key == "expkey")
            {
                Console.WriteLine("Вам доступно EXPERT версия!");
                ExpDocumetWorker exp = new ExpDocumetWorker();
                exp.OpenDocument();
                exp.EditDocument();
                exp.SaveDocument();
            }
            else
            {
                Console.WriteLine("Не правельный ключ! Вам доступно безплатная версия!");
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }

        }
    }


    class DocumentWorker
    {

        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт!");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про!");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про!");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован!");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    class ExpDocumetWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате!");
        }
    }
}
