﻿// <auto-generated />
using System;
using IAR.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IAR.Infrastructure.Migrations
{
    [DbContext(typeof(IARContext))]
    [Migration("20190820130912_Seed_Test_Department")]
    partial class Seed_Test_Department
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("IAR.Domain.Admin.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BusinessAreaId");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("DisplayName");

                    b.Property<short>("IsIAO");

                    b.Property<int?>("RoleUserRoleId");

                    b.Property<string>("WindowsLoginName");

                    b.HasKey("UserId");

                    b.HasIndex("BusinessAreaId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleUserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IAR.Domain.Admin.UserLinkedUser", b =>
                {
                    b.Property<int>("UserLinkedUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LinkedUser_UserId");

                    b.Property<int?>("PrimaryUser_UserId");

                    b.HasKey("UserLinkedUserId");

                    b.HasIndex("LinkedUser_UserId");

                    b.HasIndex("PrimaryUser_UserId");

                    b.ToTable("UserLinkedUsers");
                });

            modelBuilder.Entity("IAR.Domain.Admin.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessToAsset");

                    b.Property<short>("AssetInHardCopy");

                    b.Property<short>("AssetInSystem");

                    b.Property<string>("AssetName");

                    b.Property<int?>("AssetStatusId");

                    b.Property<int?>("BILAvailability");

                    b.Property<int?>("BILConfidentiality");

                    b.Property<int?>("BILIntegrity");

                    b.Property<string>("CategoriesOfIndividuals");

                    b.Property<string>("CategoriesOfPersonalData");

                    b.Property<string>("CategoriesOfRecipients");

                    b.Property<string>("CreatedBy");

                    b.Property<short?>("DPIAPerformed");

                    b.Property<short>("DSAInPlace");

                    b.Property<DateTime?>("DSAReviewDate");

                    b.Property<string>("DataController");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("DeptReference");

                    b.Property<string>("Description");

                    b.Property<string>("EvidenceOfLC");

                    b.Property<string>("EvidenceOfSCLC");

                    b.Property<string>("FileShareLocation");

                    b.Property<int?>("GovernmentSecurityClassificationId");

                    b.Property<string>("HardcopyLocation");

                    b.Property<int?>("InformationAssetOwnerUserId");

                    b.Property<string>("JointDataController");

                    b.Property<string>("LinkToBIAssessment");

                    b.Property<string>("LinkToDPIA");

                    b.Property<string>("LinkToDataSharingAgreement");

                    b.Property<string>("LinkToDocumentation");

                    b.Property<string>("LocalResponsiblePerson");

                    b.Property<short?>("PersonalInformationHeld");

                    b.Property<string>("ReasonForProcessing");

                    b.Property<int?>("RetentionPeriodId");

                    b.Property<string>("RetentionPeriodOther");

                    b.Property<string>("RisksToAsset");

                    b.Property<string>("SystemDetails");

                    b.Property<short?>("TransfersToThirdCountries");

                    b.Property<int?>("ValueOfAssetAssetValueId");

                    b.HasKey("AssetId");

                    b.HasIndex("AssetStatusId");

                    b.HasIndex("GovernmentSecurityClassificationId");

                    b.HasIndex("InformationAssetOwnerUserId");

                    b.HasIndex("RetentionPeriodId");

                    b.HasIndex("ValueOfAssetAssetValueId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetApplicableRight", b =>
                {
                    b.Property<int>("AssetApplicableRightId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApplicableRightId");

                    b.Property<int?>("AssetId");

                    b.HasKey("AssetApplicableRightId");

                    b.HasIndex("ApplicableRightId");

                    b.HasIndex("AssetId");

                    b.ToTable("AssetApplicableRights");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetLawfulProcessingCondition", b =>
                {
                    b.Property<int>("AssetLawfulProcessingConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<int?>("LawfulProcessingConditionId");

                    b.HasKey("AssetLawfulProcessingConditionId");

                    b.HasIndex("AssetId");

                    b.HasIndex("LawfulProcessingConditionId");

                    b.ToTable("AssetLawfulProcessingConditions");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetOrganisationalSecurityMeasure", b =>
                {
                    b.Property<int>("AssetOrganisationalSecurityMeasureId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<int?>("OrganisationalSecurityMeasureId");

                    b.HasKey("AssetOrganisationalSecurityMeasureId");

                    b.HasIndex("AssetId");

                    b.HasIndex("OrganisationalSecurityMeasureId");

                    b.ToTable("AssetOrganisationalSecurityMeasures");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetPersonalDataSource", b =>
                {
                    b.Property<int>("AssetPersonalDataSourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<int?>("PersonalDataSourceId");

                    b.HasKey("AssetPersonalDataSourceId");

                    b.HasIndex("AssetId");

                    b.HasIndex("PersonalDataSourceId");

                    b.ToTable("AssetPersonalDataSources");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetPersonalDataSpecialCategory", b =>
                {
                    b.Property<int>("AssetPersonalDataSpecialCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<int?>("PersonalDataSpecialCategoryId");

                    b.HasKey("AssetPersonalDataSpecialCategoryId");

                    b.HasIndex("AssetId");

                    b.HasIndex("PersonalDataSpecialCategoryId");

                    b.ToTable("AssetPersonalDataSpecialCategories");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetSpecialCategoryLawfulProcessingCondition", b =>
                {
                    b.Property<int>("AssetSpecialCategoryLawfulProcessingConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<int?>("SpecialCategoryLawfulProcessingConditionId");

                    b.HasKey("AssetSpecialCategoryLawfulProcessingConditionId");

                    b.HasIndex("AssetId");

                    b.HasIndex("SpecialCategoryLawfulProcessingConditionId");

                    b.ToTable("AssetSpecialCategoryLawfulProcessingConditions");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.ApplicableRight", b =>
                {
                    b.Property<int>("ApplicableRightId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("ApplicableRightId");

                    b.ToTable("ApplicableRights");

                    b.HasData(
                        new
                        {
                            ApplicableRightId = 1,
                            Description = "Right to be informed"
                        },
                        new
                        {
                            ApplicableRightId = 2,
                            Description = "Right of access"
                        },
                        new
                        {
                            ApplicableRightId = 3,
                            Description = "Right to Rectification"
                        },
                        new
                        {
                            ApplicableRightId = 4,
                            Description = "Right to erasure"
                        },
                        new
                        {
                            ApplicableRightId = 5,
                            Description = "Right to restrict processing"
                        },
                        new
                        {
                            ApplicableRightId = 6,
                            Description = "Right to data portability"
                        },
                        new
                        {
                            ApplicableRightId = 7,
                            Description = "Right to object"
                        },
                        new
                        {
                            ApplicableRightId = 8,
                            Description = "Rights to automated decision making including profiling"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.AssetStatus", b =>
                {
                    b.Property<int>("AssetStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("AssetStatusId");

                    b.ToTable("AssetStatuses");

                    b.HasData(
                        new
                        {
                            AssetStatusId = 1,
                            Description = "Active"
                        },
                        new
                        {
                            AssetStatusId = 2,
                            Description = "Inactive"
                        },
                        new
                        {
                            AssetStatusId = 3,
                            Description = "Disposed"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.AssetValue", b =>
                {
                    b.Property<int>("AssetValueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("AssetValueId");

                    b.ToTable("AssetValues");

                    b.HasData(
                        new
                        {
                            AssetValueId = 1,
                            Description = "High"
                        },
                        new
                        {
                            AssetValueId = 2,
                            Description = "Medium"
                        },
                        new
                        {
                            AssetValueId = 3,
                            Description = "Low"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.BusinessArea", b =>
                {
                    b.Property<int>("BusinessAreaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessAreaName");

                    b.Property<int?>("ParentDivisionDivisionId");

                    b.HasKey("BusinessAreaId");

                    b.HasIndex("ParentDivisionDivisionId");

                    b.ToTable("BusinessAreas");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DPOName");

                    b.Property<string>("DataControllerName");

                    b.Property<string>("DepartmentAbbreviation");

                    b.Property<string>("DepartmentName");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DPOName = "Jenny Lynn",
                            DataControllerName = "Department of Finance",
                            DepartmentAbbreviation = "DoF",
                            DepartmentName = "Department of Finance"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("DivisionName");

                    b.HasKey("DivisionId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.GovernmentSecurityClassification", b =>
                {
                    b.Property<int>("GovernmentSecurityClassificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("GovernmentSecurityClassificationId");

                    b.ToTable("GovernmentSecurityClassifications");

                    b.HasData(
                        new
                        {
                            GovernmentSecurityClassificationId = 1,
                            Description = "Official"
                        },
                        new
                        {
                            GovernmentSecurityClassificationId = 2,
                            Description = "Official Sensitive"
                        },
                        new
                        {
                            GovernmentSecurityClassificationId = 3,
                            Description = "Secret"
                        },
                        new
                        {
                            GovernmentSecurityClassificationId = 4,
                            Description = "Top Secret"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.InformationAssetOwner", b =>
                {
                    b.Property<int>("InformationAssetOwnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BusinessAreaId");

                    b.Property<string>("DisplayName");

                    b.Property<string>("EmailAddress");

                    b.HasKey("InformationAssetOwnerId");

                    b.HasIndex("BusinessAreaId");

                    b.ToTable("InformationAssetOwners");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.LawfulProcessingCondition", b =>
                {
                    b.Property<int>("LawfulProcessingConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("LawfulProcessingConditionId");

                    b.ToTable("LawfulProcessingConditions");

                    b.HasData(
                        new
                        {
                            LawfulProcessingConditionId = 1,
                            Description = "Legal obligation"
                        },
                        new
                        {
                            LawfulProcessingConditionId = 2,
                            Description = "Public task"
                        },
                        new
                        {
                            LawfulProcessingConditionId = 3,
                            Description = "Consent"
                        },
                        new
                        {
                            LawfulProcessingConditionId = 4,
                            Description = "Contract"
                        },
                        new
                        {
                            LawfulProcessingConditionId = 5,
                            Description = "Vital interest"
                        },
                        new
                        {
                            LawfulProcessingConditionId = 6,
                            Description = "Legitimate interest"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.OrganisationalSecurityMeasure", b =>
                {
                    b.Property<int>("OrganisationalSecurityMeasureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("OrganisationalSecurityMeasureId");

                    b.ToTable("OrganisationalSecurityMeasures");

                    b.HasData(
                        new
                        {
                            OrganisationalSecurityMeasureId = 1,
                            Description = "Encrypted storage"
                        },
                        new
                        {
                            OrganisationalSecurityMeasureId = 2,
                            Description = "Encrypted transfer"
                        },
                        new
                        {
                            OrganisationalSecurityMeasureId = 3,
                            Description = "Access controls"
                        },
                        new
                        {
                            OrganisationalSecurityMeasureId = 4,
                            Description = "Documented processes in place for handling personal data"
                        },
                        new
                        {
                            OrganisationalSecurityMeasureId = 5,
                            Description = "Training"
                        },
                        new
                        {
                            OrganisationalSecurityMeasureId = 6,
                            Description = "Business continuity plan"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.PersonalDataSource", b =>
                {
                    b.Property<int>("PersonalDataSourceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("PersonalDataSourceId");

                    b.ToTable("PersonalDataSources");

                    b.HasData(
                        new
                        {
                            PersonalDataSourceId = 1,
                            Description = "Data subject"
                        },
                        new
                        {
                            PersonalDataSourceId = 2,
                            Description = "Data controller"
                        },
                        new
                        {
                            PersonalDataSourceId = 3,
                            Description = "3rd party"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.PersonalDataSpecialCategory", b =>
                {
                    b.Property<int>("PersonalDataSpecialCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("PersonalDataSpecialCategoryId");

                    b.ToTable("PersonalDataSpecialCategories");

                    b.HasData(
                        new
                        {
                            PersonalDataSpecialCategoryId = 1,
                            Description = "Race"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 2,
                            Description = "Ethnic origin"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 3,
                            Description = "Political opinion"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 4,
                            Description = "Religious or philosophical beliefs"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 5,
                            Description = "Trade union membership"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 6,
                            Description = "Genetics"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 7,
                            Description = "Biometrics (where used for ID purposes)"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 8,
                            Description = "Physical and mental health"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 9,
                            Description = "Sex life"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 10,
                            Description = "Sexual orientation"
                        },
                        new
                        {
                            PersonalDataSpecialCategoryId = 11,
                            Description = "None"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.ProtectiveMarkingClassification", b =>
                {
                    b.Property<int>("ProtectiveMarkingClassificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProtectiveMarkingClassificationDescription");

                    b.HasKey("ProtectiveMarkingClassificationId");

                    b.ToTable("ProtectiveMarkingClassifications");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.RetentionPeriod", b =>
                {
                    b.Property<int>("RetentionPeriodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("RetentionPeriodId");

                    b.ToTable("RetentionPeriods");

                    b.HasData(
                        new
                        {
                            RetentionPeriodId = 1,
                            Description = "Never"
                        },
                        new
                        {
                            RetentionPeriodId = 2,
                            Description = "1 year"
                        },
                        new
                        {
                            RetentionPeriodId = 3,
                            Description = "2 years"
                        },
                        new
                        {
                            RetentionPeriodId = 4,
                            Description = "10 years"
                        },
                        new
                        {
                            RetentionPeriodId = 5,
                            Description = "Other - Please specify"
                        });
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.SpecialCategoryLawfulProcessingCondition", b =>
                {
                    b.Property<int>("SpecialCategoryLawfulProcessingConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("SpecialCategoryLawfulProcessingConditionId");

                    b.ToTable("SpecialCategoryLawfulProcessingConditions");

                    b.HasData(
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 1,
                            Description = "Explicit consent"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 2,
                            Description = "Employment and Social Security and Social Protection law"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 3,
                            Description = "Vital interests of data subject"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 4,
                            Description = "Public health"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 5,
                            Description = "Made public by the data subject"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 6,
                            Description = "Substantial public interest"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 7,
                            Description = "Statistical/Research"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 8,
                            Description = "Establishment, exercise or defence of legal claims"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 9,
                            Description = "Legitimate activities"
                        },
                        new
                        {
                            SpecialCategoryLawfulProcessingConditionId = 10,
                            Description = "Employee health and social care"
                        });
                });

            modelBuilder.Entity("IAR.Domain.Admin.User", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.BusinessArea", "BusinessArea")
                        .WithMany()
                        .HasForeignKey("BusinessAreaId");

                    b.HasOne("IAR.Domain.LookupLists.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("IAR.Domain.Admin.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleUserRoleId");
                });

            modelBuilder.Entity("IAR.Domain.Admin.UserLinkedUser", b =>
                {
                    b.HasOne("IAR.Domain.Admin.User", "LinkedUser")
                        .WithMany()
                        .HasForeignKey("LinkedUser_UserId");

                    b.HasOne("IAR.Domain.Admin.User", "PrimaryUser")
                        .WithMany("LinkedUsers")
                        .HasForeignKey("PrimaryUser_UserId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.Asset", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.AssetStatus", "AssetStatus")
                        .WithMany()
                        .HasForeignKey("AssetStatusId");

                    b.HasOne("IAR.Domain.LookupLists.GovernmentSecurityClassification", "GovernmentSecurityClassification")
                        .WithMany()
                        .HasForeignKey("GovernmentSecurityClassificationId");

                    b.HasOne("IAR.Domain.Admin.User", "InformationAssetOwner")
                        .WithMany()
                        .HasForeignKey("InformationAssetOwnerUserId");

                    b.HasOne("IAR.Domain.LookupLists.RetentionPeriod", "RetentionPeriod")
                        .WithMany()
                        .HasForeignKey("RetentionPeriodId");

                    b.HasOne("IAR.Domain.LookupLists.AssetValue", "ValueOfAsset")
                        .WithMany()
                        .HasForeignKey("ValueOfAssetAssetValueId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetApplicableRight", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.ApplicableRight", "ApplicableRight")
                        .WithMany("AssetApplicableRights")
                        .HasForeignKey("ApplicableRightId");

                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("ApplicableRights")
                        .HasForeignKey("AssetId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetLawfulProcessingCondition", b =>
                {
                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("LawfulProcessingConditions")
                        .HasForeignKey("AssetId");

                    b.HasOne("IAR.Domain.LookupLists.LawfulProcessingCondition", "LawfulProcessingCondition")
                        .WithMany("AssetLawfulProcessingCondition")
                        .HasForeignKey("LawfulProcessingConditionId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetOrganisationalSecurityMeasure", b =>
                {
                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("OrganisationalSecurityMeasures")
                        .HasForeignKey("AssetId");

                    b.HasOne("IAR.Domain.LookupLists.OrganisationalSecurityMeasure", "OrganisationalSecurityMeasure")
                        .WithMany("AssetOrganisationalSecurityMeasure")
                        .HasForeignKey("OrganisationalSecurityMeasureId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetPersonalDataSource", b =>
                {
                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("PersonalDataSources")
                        .HasForeignKey("AssetId");

                    b.HasOne("IAR.Domain.LookupLists.PersonalDataSource", "PersonalDataSource")
                        .WithMany("AssetPersonalDataSource")
                        .HasForeignKey("PersonalDataSourceId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetPersonalDataSpecialCategory", b =>
                {
                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("PersonalDataSpecialCategories")
                        .HasForeignKey("AssetId");

                    b.HasOne("IAR.Domain.LookupLists.PersonalDataSpecialCategory", "PersonalDataSpecialCategory")
                        .WithMany("AssetPersonalDataSpecialCategory")
                        .HasForeignKey("PersonalDataSpecialCategoryId");
                });

            modelBuilder.Entity("IAR.Domain.InformationAssets.AssetSpecialCategoryLawfulProcessingCondition", b =>
                {
                    b.HasOne("IAR.Domain.InformationAssets.Asset", "Asset")
                        .WithMany("SpecialCategoryLawfulProcessingConditions")
                        .HasForeignKey("AssetId");

                    b.HasOne("IAR.Domain.LookupLists.SpecialCategoryLawfulProcessingCondition", "SpecialCategoryLawfulProcessingCondition")
                        .WithMany("AssetSpecialCategoryLawfulProcessingCondition")
                        .HasForeignKey("SpecialCategoryLawfulProcessingConditionId");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.BusinessArea", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.Division", "ParentDivision")
                        .WithMany("BusinessAreas")
                        .HasForeignKey("ParentDivisionDivisionId");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.Division", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.Department", "Department")
                        .WithMany("Divisions")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("IAR.Domain.LookupLists.InformationAssetOwner", b =>
                {
                    b.HasOne("IAR.Domain.LookupLists.BusinessArea", "BusinessArea")
                        .WithMany()
                        .HasForeignKey("BusinessAreaId");
                });
#pragma warning restore 612, 618
        }
    }
}