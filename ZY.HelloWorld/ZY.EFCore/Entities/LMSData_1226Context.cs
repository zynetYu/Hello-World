using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZY.EFCore.Entities
{
    public partial class LMSData_1226Context : DbContext
    {
        public LMSData_1226Context()
        {
        }

        public LMSData_1226Context(DbContextOptions<LMSData_1226Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CrmOrder> CrmOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrmOrder>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CRM_Order");

                entity.HasIndex(e => e.CAuditTime)
                    .HasName("ix_CRM_Order_AuditTime");

                entity.HasIndex(e => e.CBaseOrderId);

                entity.HasIndex(e => e.CBill);

                entity.HasIndex(e => e.CBillDept)
                    .HasName("IX_CRM_Order_BillDept");

                entity.HasIndex(e => e.CClientId)
                    .HasName("ix_CRM_Order_ClientID");

                entity.HasIndex(e => e.CClientInterCourseId)
                    .HasName("ix_CRM_Order_ClientInterCourse");

                entity.HasIndex(e => e.CCode)
                    .HasName("IX_CRM_Order_Code")
                    .IsUnique();

                entity.HasIndex(e => e.CCreateTime)
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.CCreator)
                    .HasName("IX_CRM_Order_Creator");

                entity.HasIndex(e => e.CCrmId)
                    .HasName("IX_CRM_Order_CRMID");

                entity.HasIndex(e => e.CDeputy);

                entity.HasIndex(e => e.CFactMoney);

                entity.HasIndex(e => e.CLockedPeople);

                entity.HasIndex(e => e.CLockedTime);

                entity.HasIndex(e => e.CMediaId);

                entity.HasIndex(e => e.CStatus);

                entity.HasIndex(e => new { e.CClientId, e.CStatus, e.CAuditTime })
                    .HasName("IX_CRM_Order_AuditTime_Status");

                entity.HasIndex(e => new { e.CId, e.CMediaId, e.CBuyMode })
                    .HasName("IX_Crm_Order_MediaID_BuyMode");

                entity.Property(e => e.CId)
                    .HasColumnName("C_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CAddress)
                    .HasColumnName("C_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.CAddressee)
                    .HasColumnName("C_Addressee")
                    .HasMaxLength(255);

                entity.Property(e => e.CAfterCardNum)
                    .HasColumnName("C_AfterCardNum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAfterIncrement)
                    .HasColumnName("C_AfterIncrement")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAfterLevel).HasColumnName("C_AfterLevel");

                entity.Property(e => e.CAfterMoney)
                    .HasColumnName("C_AfterMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAfterPoint)
                    .HasColumnName("C_AfterPoint")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAfterRedPacket)
                    .HasColumnName("C_AfterRedPacket")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAfterVolume)
                    .HasColumnName("C_AfterVolume")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CApprovalAmount).HasColumnName("C_ApprovalAmount");

                entity.Property(e => e.CApprovalMoney)
                    .HasColumnName("C_ApprovalMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CApprovalPoint)
                    .HasColumnName("C_ApprovalPoint")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CApprovalPostage)
                    .HasColumnName("C_ApprovalPostage")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CApprovalRedPacket)
                    .HasColumnName("C_ApprovalRedPacket")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CApprovalVolume)
                    .HasColumnName("C_ApprovalVolume")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CAudit).HasColumnName("C_Audit");

                entity.Property(e => e.CAuditDesc)
                    .HasColumnName("C_AuditDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.CAuditTime)
                    .HasColumnName("C_AuditTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CBaseOrderId).HasColumnName("C_BaseOrderID");

                entity.Property(e => e.CBeforeCardNum)
                    .HasColumnName("C_BeforeCardNum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBeforeIncrement)
                    .HasColumnName("C_BeforeIncrement")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBeforeLevel).HasColumnName("C_BeforeLevel");

                entity.Property(e => e.CBeforeMoney)
                    .HasColumnName("C_BeforeMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBeforePoint)
                    .HasColumnName("C_BeforePoint")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBeforeRedPacket)
                    .HasColumnName("C_BeforeRedPacket")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBeforeVolume)
                    .HasColumnName("C_BeforeVolume")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CBill).HasColumnName("C_Bill");

                entity.Property(e => e.CBillDept).HasColumnName("C_BillDept");

                entity.Property(e => e.CBuyMode).HasColumnName("C_BuyMode");

                entity.Property(e => e.CCardNum)
                    .HasColumnName("C_CardNum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CClientAddress).HasColumnName("C_ClientAddress");

                entity.Property(e => e.CClientId).HasColumnName("C_ClientID");

                entity.Property(e => e.CClientInterCourseId).HasColumnName("C_ClientInterCourseID");

                entity.Property(e => e.CCode)
                    .HasColumnName("C_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CCommSum)
                    .HasColumnName("C_CommSum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CCompanyId).HasColumnName("C_CompanyID");

                entity.Property(e => e.CCreateTime)
                    .HasColumnName("C_CreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CCreator).HasColumnName("C_Creator");

                entity.Property(e => e.CCrmId).HasColumnName("C_CrmID");

                entity.Property(e => e.CDeputy).HasColumnName("C_Deputy");

                entity.Property(e => e.CDeputyDeptId).HasColumnName("C_DeputyDeptID");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_Description")
                    .HasMaxLength(2000);

                entity.Property(e => e.CDiscount)
                    .HasColumnName("C_Discount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CDistribute).HasColumnName("C_Distribute");

                entity.Property(e => e.CExamReason)
                    .HasColumnName("C_ExamReason")
                    .HasMaxLength(2000);

                entity.Property(e => e.CExamTime)
                    .HasColumnName("C_ExamTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CExpress).HasColumnName("C_Express");

                entity.Property(e => e.CFactMoney)
                    .HasColumnName("C_FactMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CFlowId).HasColumnName("C_FlowID");

                entity.Property(e => e.CIsCallTel).HasColumnName("C_IsCallTel");

                entity.Property(e => e.CIsCancel).HasColumnName("C_IsCancel");

                entity.Property(e => e.CIsDelete).HasColumnName("C_IsDelete");

                entity.Property(e => e.CIsExam).HasColumnName("C_IsExam");

                entity.Property(e => e.CIsException).HasColumnName("C_IsException");

                entity.Property(e => e.CIsInsteard).HasColumnName("C_IsInsteard");

                entity.Property(e => e.CIsOosSend).HasColumnName("C_IsOosSend");

                entity.Property(e => e.CIsOtherIncrept).HasColumnName("C_IsOtherIncrept");

                entity.Property(e => e.CIsOwe).HasColumnName("C_IsOwe");

                entity.Property(e => e.CIsPart).HasColumnName("C_IsPart");

                entity.Property(e => e.CIsPassExam).HasColumnName("C_IsPassExam");

                entity.Property(e => e.CIsPurchase).HasColumnName("C_IsPurchase");

                entity.Property(e => e.CIsReceipt).HasColumnName("C_IsReceipt");

                entity.Property(e => e.CIsReceive).HasColumnName("C_IsReceive");

                entity.Property(e => e.CIsSelfUse).HasColumnName("C_IsSelfUse");

                entity.Property(e => e.CIsSend).HasColumnName("C_IsSend");

                entity.Property(e => e.CIsSplit).HasColumnName("C_IsSplit");

                entity.Property(e => e.CIsSplitDone).HasColumnName("C_IsSplitDone");

                entity.Property(e => e.CIsSplitOrder).HasColumnName("C_IsSplitOrder");

                entity.Property(e => e.CLead).HasColumnName("C_Lead");

                entity.Property(e => e.CLockedPeople).HasColumnName("C_LockedPeople");

                entity.Property(e => e.CLockedTime)
                    .HasColumnName("C_LockedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CMarketSum)
                    .HasColumnName("C_MarketSum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CMediaId).HasColumnName("C_MediaID");

                entity.Property(e => e.CModifier).HasColumnName("C_Modifier");

                entity.Property(e => e.CModifyTime)
                    .HasColumnName("C_ModifyTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.COperateSkillCode)
                    .HasColumnName("C_OperateSkillCode")
                    .HasMaxLength(255);

                entity.Property(e => e.COrderDesc)
                    .HasColumnName("C_OrderDesc")
                    .HasMaxLength(2000);

                entity.Property(e => e.COtherDiscount)
                    .HasColumnName("C_OtherDiscount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.COtherSum)
                    .HasColumnName("C_OtherSum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CPaymentMode).HasColumnName("C_PaymentMode");

                entity.Property(e => e.CPostTime)
                    .HasColumnName("C_PostTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPreferentialPrice)
                    .HasColumnName("C_PreferentialPrice")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CReceiptDesc)
                    .HasColumnName("C_ReceiptDesc")
                    .HasMaxLength(255);

                entity.Property(e => e.CReceiptTitle)
                    .HasColumnName("C_ReceiptTitle")
                    .HasMaxLength(255);

                entity.Property(e => e.CReceivableMoney)
                    .HasColumnName("C_ReceivableMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CRegion).HasColumnName("C_Region");

                entity.Property(e => e.CSendDept).HasColumnName("C_SendDept");

                entity.Property(e => e.CSendDiscount)
                    .HasColumnName("C_SendDiscount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSendIncrement)
                    .HasColumnName("C_SendIncrement")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSendMode).HasColumnName("C_SendMode");

                entity.Property(e => e.CSendMoney)
                    .HasColumnName("C_SendMoney")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSendPoint)
                    .HasColumnName("C_SendPoint")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSendRedPacket)
                    .HasColumnName("C_SendRedPacket")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSendTel)
                    .HasColumnName("C_SendTel")
                    .HasMaxLength(255);

                entity.Property(e => e.CSendTime)
                    .HasColumnName("C_SendTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSendVolume)
                    .HasColumnName("C_SendVolume")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CSingleTime)
                    .HasColumnName("C_SingleTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSingler).HasColumnName("C_Singler");

                entity.Property(e => e.CSource).HasColumnName("C_Source");

                entity.Property(e => e.CStatus).HasColumnName("C_Status");

                entity.Property(e => e.CStoreId).HasColumnName("C_StoreID");

                entity.Property(e => e.CSubCenterId).HasColumnName("C_SubCenterID");

                entity.Property(e => e.CType).HasColumnName("C_Type");

                entity.Property(e => e.CUnJdSubcenter).HasColumnName("C_UnJdSubcenter");

                entity.Property(e => e.CUseCardNum)
                    .HasColumnName("C_UseCardNum")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CUsedIncrement)
                    .HasColumnName("C_UsedIncrement")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CUsedPoint)
                    .HasColumnName("C_UsedPoint")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CUsedRedPacket)
                    .HasColumnName("C_UsedRedPacket")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CUsedVolume)
                    .HasColumnName("C_UsedVolume")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CZipCode)
                    .HasColumnName("C_ZipCode")
                    .HasMaxLength(255);
            });

            modelBuilder.HasSequence("GlobalSequence").StartsAt(7000000000);
        }
    }
}
