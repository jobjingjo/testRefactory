using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Services.Models;

namespace WebApplication.Services.Data
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            //builder.ToTable("Student");
            //builder.Property(s => s.Age)
            //    .IsRequired(false);
            //builder.Property(s => s.IsRegularStudent)
            //    .HasDefaultValue(true);
            builder.HasData(
                new Manufacturer { Id = "E74EA75C-EF51-40E1-BD83-086805F32060", ManufacturerName = "STARCRAFT" },
                new Manufacturer { Id = "33E32587-A5A8-4CF9-86EE-093197C63776", ManufacturerName = "AUDI" },
                new Manufacturer { Id = "2D2158D4-96DA-4EBC-A62C-0C41EE98F8E3", ManufacturerName = "LAMBORGHINI" },
                new Manufacturer { Id = "4E947C05-CD13-4136-9AA5-0CE9CAFF3349", ManufacturerName = "ISUZU" },
                new Manufacturer { Id = "7C092475-3EB2-47F9-A583-0DD5576E8005", ManufacturerName = "FIAT" },
                new Manufacturer { Id = "65D6C514-C10C-45E1-A5B3-0E499F47128E", ManufacturerName = "HYUNDAI" },
                new Manufacturer { Id = "3D958555-0A1D-4463-B6B4-17F71012D660", ManufacturerName = "DODGE" },
                new Manufacturer { Id = "8C2F5142-08DC-441B-8D22-1AACF475B1EE", ManufacturerName = "PEUGEOT" },
                new Manufacturer { Id = "C7D167E8-9458-4F72-9D5C-1B42D92FBDC6", ManufacturerName = "EUROPE FORD" },
                new Manufacturer { Id = "43C2D407-171C-4061-AB7E-1F45C200E6EB", ManufacturerName = "AMG" },
                new Manufacturer { Id = "C095FB9A-6616-420F-B6F7-1F9060F9F662", ManufacturerName = "ROLLSROYCE" },
                new Manufacturer { Id = "E665180E-DA4B-45A0-95E7-21AFFF4201FB", ManufacturerName = "BUICK" },
                new Manufacturer { Id = "F79BF5D1-D22B-4C9D-AF6C-23B63829343E", ManufacturerName = "MASERATI" },
                new Manufacturer { Id = "2D0D8E51-08A8-40C3-B729-25F002493322", ManufacturerName = "SUZUKI" },
                new Manufacturer { Id = "D43FCB87-8EB3-4BDC-999F-289DDC3E494E", ManufacturerName = "DAIMLER" },
                new Manufacturer { Id = "7B32052D-44BE-4F29-BFEB-31ECEFBD19C8", ManufacturerName = "LANCIA" },
                new Manufacturer { Id = "5B86E249-FAEA-48D0-8378-34B357C73E10", ManufacturerName = "CT&T" },
                new Manufacturer { Id = "E456911F-2C35-43C8-A3D1-3561B774BCEF", ManufacturerName = "NISSAN" },
                new Manufacturer { Id = "C35A4E7B-0E1A-4002-B648-47F537CA7BF1", ManufacturerName = "ASTON MARTIN" },
                new Manufacturer { Id = "BFD10ACD-92D5-4F29-9C78-4D145DB1C783", ManufacturerName = "TOYOTA" },
                new Manufacturer { Id = "20697E01-ED05-41CC-A815-4D2E3A4CE99C", ManufacturerName = "YES" },
                new Manufacturer { Id = "0296F64B-FA83-4285-BA77-4E4FAFF4CD39", ManufacturerName = "OPEL" },
                new Manufacturer { Id = "9D920E72-C50A-4554-83AA-4F6CA84CA3A6", ManufacturerName = "DAIHATSU" },
                new Manufacturer { Id = "F63C4D3F-85F9-46BA-9938-504E4780525F", ManufacturerName = "SUBARU" },
                new Manufacturer { Id = "D31751D4-7306-4C92-90D1-58ED12ACB972", ManufacturerName = "LINCOLN" },
                new Manufacturer { Id = "F7087EC7-9392-4626-B641-5B006B93ED29", ManufacturerName = "HONDA" },
                new Manufacturer { Id = "66959688-287F-4DBB-BE10-5D54DFD78F5B", ManufacturerName = "ABARTH" },
                new Manufacturer { Id = "AE937731-F027-408A-AB12-5DEB80B45C60", ManufacturerName = "PONTIAC" },
                new Manufacturer { Id = "85716B45-8139-491C-B0A4-5E31D4419A3D", ManufacturerName = "HUMMER" },
                new Manufacturer { Id = "A7489A80-F142-496A-B776-5E8FBACFD8E0", ManufacturerName = "MAZDA" },
                new Manufacturer { Id = "DA040730-9659-498A-994E-5F7F6852208D", ManufacturerName = "AUTOBIANCHI" },
                new Manufacturer { Id = "B1A413BA-2C00-4A59-9910-66AEDECDA9E3", ManufacturerName = "DONKERVOORT" },
                new Manufacturer { Id = "1F23F337-7B28-4B8D-A816-6B9DB1FD0360", ManufacturerName = "MINI" },
                new Manufacturer { Id = "C75E9153-364D-49FC-9C66-6BFA58F98FFB", ManufacturerName = "CITROEN" },
                new Manufacturer { Id = "6AC3C5BB-60F5-4280-A1DF-73FFAC597816", ManufacturerName = "CHRYSLER" },
                new Manufacturer { Id = "B226A88A-B460-4098-9C49-75A711B58867", ManufacturerName = "ROVER" },
                new Manufacturer { Id = "DDD335EF-C0CA-4917-AF81-774FD2A7270B", ManufacturerName = "BENTLEY" },
                new Manufacturer { Id = "9370C145-D1FC-4F86-AC18-7934D2FD996B", ManufacturerName = "TIARA" },
                new Manufacturer { Id = "A65DBDD1-0227-4249-840D-7B9DF1AA1C01", ManufacturerName = "BMW ALPINA" },
                new Manufacturer { Id = "8C239C9E-93BB-41F8-8712-7C0860EE71EC", ManufacturerName = "VOLVO" },
                new Manufacturer { Id = "450FD683-7A50-4E7A-8B71-7DD109689740", ManufacturerName = "MORGAN" },
                new Manufacturer { Id = "0975EF88-66CE-47CC-A7F3-7FA7E4C0DC02", ManufacturerName = "SAAB" },
                new Manufacturer { Id = "43E2EF54-A8C5-475B-B124-861D47C989C0", ManufacturerName = "KIA" },
                new Manufacturer { Id = "DD102D49-CFB6-46D2-A262-864413466FA6", ManufacturerName = "Alfa Romeo" },
                new Manufacturer { Id = "5C080CDE-C53D-46BF-A01B-8DC503AD40AA", ManufacturerName = "MERCURY" },
                new Manufacturer { Id = "45E3890F-DDC1-4849-A6DC-975B2FFEF71A", ManufacturerName = "JAGUAR" },
                new Manufacturer { Id = "15A1FF39-9B90-4090-959D-9CFDDA2EE5BF", ManufacturerName = "CADILLAC" },
                new Manufacturer { Id = "6B055302-3A0E-473A-81AB-AA6B85DE14A2", ManufacturerName = "MERCEDES AMG" },
                new Manufacturer { Id = "41BB5DF9-29F2-4025-BB4E-B94EE3B60615", ManufacturerName = "MAYBACH" },
                new Manufacturer { Id = "3193D6A4-4974-4DE8-8CAC-BA216AFA41FC", ManufacturerName = "FORD" },
                new Manufacturer { Id = "F65F9D1D-2BA9-4B3C-851F-BBB5B231E52E", ManufacturerName = "BMW" },
                new Manufacturer { Id = "B61227A8-C640-480B-A3AB-C3826A401516", ManufacturerName = "MITSUOKA" },
                new Manufacturer { Id = "973BFABB-07A0-4F76-8635-C77A306F4F7A", ManufacturerName = "EUNOS" },
                new Manufacturer { Id = "DB312E7B-9D17-471E-AC8F-C9DFDE820ADC", ManufacturerName = "LEXUS" },
                new Manufacturer { Id = "730C5AFE-F4AC-4301-8CC7-CB01CBD4D01E", ManufacturerName = "VOLKSWAGEN" },
                new Manufacturer { Id = "FA8113E4-C57D-4A50-866F-CD97B9400696", ManufacturerName = "MERCEDES BENZ" },
                new Manufacturer { Id = "64A313BD-A53B-4F59-AB5E-CFD2E6759B6A", ManufacturerName = "RENAULT" },
                new Manufacturer { Id = "19425355-B6C3-434C-867F-CFECF2AF5A74", ManufacturerName = "CHEVROLET" },
                new Manufacturer { Id = "1A8ED648-F63A-4138-899A-D2BB23DC8E39", ManufacturerName = "PORSCHE" },
                new Manufacturer { Id = "F9884273-31EB-4E1F-AE54-D647F4EAE72D", ManufacturerName = "MITSUBISHI" },
                new Manufacturer { Id = "46DE7CC6-17D5-492E-9F77-D903F206AF4A", ManufacturerName = "MG" },
                new Manufacturer { Id = "D2D0C06D-6B43-48C4-B7F0-E1060CB1BAE9", ManufacturerName = "LAND ROVER" },
                new Manufacturer { Id = "82A2A0EE-8DD1-4F27-9356-E9A5AF96F6AE", ManufacturerName = "DAEWOO" },
                new Manufacturer { Id = "DA89378F-9575-418A-A0A3-EB06C6249000", ManufacturerName = "VENTURI" },
                new Manufacturer { Id = "0BCF1E44-F3E2-4E0D-AD03-EB2959CE5337", ManufacturerName = "FERRARI" },
                new Manufacturer { Id = "54F3C52B-C9C9-4A55-9555-EC3CEC96303F", ManufacturerName = "SMART" },
                new Manufacturer { Id = "557AD2D9-8F4B-439D-9D0F-EC93BFD9939A", ManufacturerName = "SATURN" },
                new Manufacturer { Id = "4588CAD8-90C2-4E00-A729-F063C024722E", ManufacturerName = "TVR" },
                new Manufacturer { Id = "D2625ADD-806B-4056-9895-F18ADB012FC3", ManufacturerName = "LOTUS" },
                new Manufacturer { Id = "33C29264-B292-4852-9142-F4BC5561C3CC", ManufacturerName = "FORD JAPAN" },
                new Manufacturer { Id = "4B9962D0-6A1A-4D85-A4BA-F6C66FE2F271", ManufacturerName = "CHRYSLER JEEP" }
            );

        }
    }
}
