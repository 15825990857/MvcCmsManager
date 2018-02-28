namespace CmsManager.Data.Migrations
{
    using Common;
    using Core.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CmsManager.Data.DbBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CmsManager.Data.DbBaseContext context)
        {
             //������Ա�˻�ʼ��ֵ
            context.Set<User>().AddOrUpdate(
                p=>p.UserName,
                new User
                {
                    ID=1,
                    UserName = "admin",
                    CreateTime = DateTime.Now,
                    Pwd = Encrypt.EncryptMD5By32("123456"),
                    Status = 2
                }
             );

            //��ʼ�������˵�
            context.Set<Menu>().AddOrUpdate(
                p => p.Text,
                new Menu
                {
                    ID =1,
                    type = 1,
                    Status = 2,
                    Index = 1,
                    Parent = 0,
                    Text = "��������",
                    CreateTime = DateTime.Now
                },
                new Menu {
                    ID=2,
                    type = 1,
                    Status = 2,
                    Index = 2,
                    Parent = 0,
                    Text = "ϵͳ����",
                    CreateTime = DateTime.Now
                },
                    new Menu
                    {
                        ID=3,
                        type = 1,
                        Status = 2,
                        Index = 2,
                        Parent = 2,
                        Text = "�˵�����",
                        CreateTime = DateTime.Now
                    },
                    new Menu {
                        ID=4,
                        type=1,
                        Status=2,
                        Index=3,
                        Parent=3,
                        Text="�˵�ά��",
                        CreateTime=DateTime.Now
                    }
                );
            //��ť
            context.Set<Button>().AddOrUpdate(
                p => p.Text,
                new Button
                {
                    Text = "����"
                },
                new Button {
                    Text="�޸�"
                },new Button {
                    Text="ɾ��"
                }
                );
        }
    }
}
