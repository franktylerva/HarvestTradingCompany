﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01728ae3-a5b6-4740-b9cc-8865214352b2"), "Product-65" },
                    { new Guid("0279a0cc-4827-4412-b42f-a827ede20de9"), "Product-49" },
                    { new Guid("02e8eb0c-a652-4b9f-80b5-69e8731909b1"), "Product-40" },
                    { new Guid("070b490f-07d6-47b3-b1a9-7ff533c158c5"), "Product-64" },
                    { new Guid("08a049cd-7e8b-472b-a2c6-12f8f27ca93b"), "Product-48" },
                    { new Guid("0b47d06e-26c0-4177-9b02-9eebea0bcd13"), "Product-7" },
                    { new Guid("10164512-429f-4464-9b78-b9df2adbda8d"), "Product-52" },
                    { new Guid("13962d54-e5d4-4b86-976e-db0eb752c945"), "Product-16" },
                    { new Guid("1f617ed5-ca9e-44ef-b0f3-5942b38a0993"), "Product-85" },
                    { new Guid("24906940-3c12-4b75-8600-4c9df836f9a4"), "Product-29" },
                    { new Guid("263384f0-e8c5-4ec1-9d0a-160d4ccd44a4"), "Product-10" },
                    { new Guid("2e14f6ad-274e-42df-9aea-c7a6052bfa55"), "Product-55" },
                    { new Guid("321fb944-caad-4419-83db-acebb48b62df"), "Product-47" },
                    { new Guid("3296f098-ac66-4637-bd0f-3fa7bcfa2691"), "Product-25" },
                    { new Guid("32dd4cc3-78a0-4a9f-972a-248c6d3ee69e"), "Product-19" },
                    { new Guid("3312106e-b2c1-40ef-b6d9-e65d257cd71f"), "Product-42" },
                    { new Guid("33ead369-29e4-4b96-a7e7-f3c37ba1bf0b"), "Product-74" },
                    { new Guid("34349e98-c2db-4828-aaf5-d3bcaef34e16"), "Product-93" },
                    { new Guid("3537b196-a8bf-49d3-bfb3-5fd30215e521"), "Product-51" },
                    { new Guid("37e8353b-8c1b-4eac-bc02-dca4548efc62"), "Product-76" },
                    { new Guid("3acedeed-ead3-466d-8ab7-740cc5098563"), "Product-58" },
                    { new Guid("3e388d46-ef6a-4b2a-8d29-944c5a01b6bf"), "Product-72" },
                    { new Guid("3e9c69fd-ec35-48fe-bcc1-1965975a9656"), "Product-81" },
                    { new Guid("3fc4ff07-b165-46df-ac87-d825ae428f89"), "Product-18" },
                    { new Guid("415426fa-4374-45cf-b792-d86e37cb9ced"), "Product-90" },
                    { new Guid("422ae119-c5ce-4a35-b597-afff8846c4a8"), "Product-88" },
                    { new Guid("454582a8-5218-49a6-9596-2c9aa4833e1e"), "Product-97" },
                    { new Guid("4575d404-64fa-44e7-aa08-23ce07044529"), "Product-67" },
                    { new Guid("4c8dcc59-ed24-4cf2-a299-afaa2f9381f3"), "Product-43" },
                    { new Guid("527d9df3-78ba-4add-b733-c09b440068c5"), "Product-39" },
                    { new Guid("5a3d9ab2-1d12-4ffa-8c2e-c32896c2a5b5"), "Product-63" },
                    { new Guid("5e0b652f-74d9-4ea5-a497-ebd81126a508"), "Product-45" },
                    { new Guid("5fc48855-0836-499b-be80-3275062485d1"), "Product-44" },
                    { new Guid("5ffb3c03-e981-4e0a-85c1-264af9f9eca0"), "Product-69" },
                    { new Guid("612f8457-355a-458f-93d5-14ab4b82eeb7"), "Product-92" },
                    { new Guid("63d3feb9-6d12-4f9c-a128-a6c49d1e4f2e"), "Product-15" },
                    { new Guid("63d436d5-d0b1-4764-8601-5b5c61360198"), "Product-96" },
                    { new Guid("64e28ba2-edf6-4165-9fed-5ad71ca03367"), "Product-84" },
                    { new Guid("688e3468-dd7c-4f64-8021-d1ab3a7ab09b"), "Product-68" },
                    { new Guid("6e3a6873-ada1-47bf-902f-0294f0b4a93d"), "Product-13" },
                    { new Guid("720e2401-375d-4a6d-8353-d37444faec6b"), "Product-41" },
                    { new Guid("7a0acf36-acf7-4f81-a78c-9e763a5b04cb"), "Product-62" },
                    { new Guid("7a3ba514-472f-4c46-8eb0-7169f053877c"), "Product-99" },
                    { new Guid("7b97a365-8b93-4146-816a-f13ae92c2dbd"), "Product-27" },
                    { new Guid("7c762491-96d9-4d8f-be38-18d1a944be57"), "Product-54" },
                    { new Guid("802f8921-ec7f-499e-ba91-bcfe0d3b34f0"), "Product-14" },
                    { new Guid("81a841de-e086-4402-a97d-9d843ae11c96"), "Product-11" },
                    { new Guid("83540bad-d44d-40c0-bde1-8ad5e44a3cb9"), "Product-61" },
                    { new Guid("8915af73-87b7-4132-9cc1-9ef42d40cd3a"), "Product-75" },
                    { new Guid("89ed0b75-5fe0-4c0c-a422-b15b3623c316"), "Product-53" },
                    { new Guid("8f7126bd-5422-479d-a9b2-9338f8476237"), "Product-86" },
                    { new Guid("902dddc1-c80b-42c3-bd49-533ed7d6aa2e"), "Product-83" },
                    { new Guid("91bdadb8-b5e2-4a6b-a963-65b64e3787fc"), "Product-95" },
                    { new Guid("92333aa8-47fc-4efe-85a7-15e4823b8854"), "Product-59" },
                    { new Guid("92f16a18-e8b2-4801-941d-ebe0f65cc1cb"), "Product-73" },
                    { new Guid("95ba8ed5-a91a-49a1-91a4-55458e8ac7b0"), "Product-56" },
                    { new Guid("9a26d1a0-e9d0-4bc5-afc5-c6a269ea11fe"), "Product-50" },
                    { new Guid("9a66a29b-dd43-4d66-b3f7-88c4140da8be"), "Product-3" },
                    { new Guid("9b4afaee-1189-4930-8247-99a8ccc4646f"), "Product-21" },
                    { new Guid("a081a02e-6f5a-431b-8881-36076a599daf"), "Product-5" },
                    { new Guid("a568b786-9a7a-488f-bdcc-a3df3f45c230"), "Product-66" },
                    { new Guid("a8c17263-1389-483a-a43d-b60a816a94ba"), "Product-28" },
                    { new Guid("aa288ec2-56ae-434e-8d53-4c7d3f7855f3"), "Product-1" },
                    { new Guid("aae5713f-0e72-4047-83af-56cb981cb4fc"), "Product-8" },
                    { new Guid("ac1cb8d4-31e1-4cbd-a1fd-514f91b6ecc5"), "Product-89" },
                    { new Guid("b0699355-b935-4fad-94ae-76478fd0d5b2"), "Product-31" },
                    { new Guid("b10fd647-c549-4782-94fc-27c1094c292a"), "Product-98" },
                    { new Guid("b33c13ac-04c1-4dfd-a86f-9605bf05b615"), "Product-36" },
                    { new Guid("b5d44736-563f-4ceb-a38a-882d3f42bf83"), "Product-23" },
                    { new Guid("b716db09-70c6-446e-8660-23ee3d785402"), "Product-100" },
                    { new Guid("b77b34af-4194-459e-9f79-264b8f8f7ac1"), "Product-12" },
                    { new Guid("b84f1cd7-c589-448e-8a37-814b175a4063"), "Product-6" },
                    { new Guid("b8d6d6eb-2a1a-4824-a4bd-8200f41c389a"), "Product-17" },
                    { new Guid("b91eed32-bf37-4b74-b4c8-5bb01865dfaa"), "Product-78" },
                    { new Guid("bc8a8e27-5262-42f5-9b35-c8c4c6a56687"), "Product-9" },
                    { new Guid("bd8880ab-1021-424d-b818-c59a5f354d49"), "Product-38" },
                    { new Guid("c4508418-18ad-4e1d-841d-e4cd886b1e3a"), "Product-22" },
                    { new Guid("c5a265cc-6ba7-4b82-aa0a-a812f0e2d38c"), "Product-30" },
                    { new Guid("c78da9e8-8806-4b36-ba38-b3285ca572fd"), "Product-91" },
                    { new Guid("c9620f82-3ae9-48a7-a8df-9179367bde42"), "Product-37" },
                    { new Guid("cae8016b-9497-4c88-9bd2-9324635c32ed"), "Product-32" },
                    { new Guid("ccc98132-e10a-4ddb-a5a8-59729c731f0b"), "Product-26" },
                    { new Guid("d366b7a9-eede-43a4-8e5e-a184f2ecbfbf"), "Product-46" },
                    { new Guid("d60192e5-9623-4317-8060-e2a47d2dadfa"), "Product-57" },
                    { new Guid("d6020765-3126-4cfc-9123-b552d935a9cc"), "Product-20" },
                    { new Guid("d6a6c4dd-2aa0-407e-9cc3-76f8a3ccc626"), "Product-34" },
                    { new Guid("d86a7ee5-44bc-451d-aba9-90ea9691cf89"), "Product-82" },
                    { new Guid("d8f8f164-25f6-48bd-b380-6e33e7c15547"), "Product-60" },
                    { new Guid("d96c1acf-4682-4197-9e6d-be6ff3f5a8aa"), "Product-24" },
                    { new Guid("df3dc634-4e69-45a1-b8c7-388c5b3d947c"), "Product-4" },
                    { new Guid("e05c7b47-1d37-456a-84c0-ac07976b488a"), "Product-35" },
                    { new Guid("e17630af-c653-46de-ad3a-aa8381c709e8"), "Product-80" },
                    { new Guid("e63599b3-4498-4bec-96dd-7c32cc97d58a"), "Product-94" },
                    { new Guid("e9739289-4764-408d-8a4e-e8cfb9d8c9b7"), "Product-87" },
                    { new Guid("ea6c193c-28a5-4aca-b3ea-3b5142f8bb47"), "Product-33" },
                    { new Guid("eb968cc9-9281-4106-b3aa-727b71f68062"), "Product-79" },
                    { new Guid("ed16f9b8-6f3e-443a-88d1-b8d5248458b3"), "Product-2" },
                    { new Guid("f24be552-4cad-45cf-9458-fdfa2e2742c8"), "Product-71" },
                    { new Guid("f9eeb43a-cd3e-4aa8-b108-348dcf65f27a"), "Product-70" },
                    { new Guid("fb7f8475-9355-4f3c-9d27-c333e6a3e129"), "Product-77" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}