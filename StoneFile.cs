using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorXmlConciliacaoStone
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Conciliation
    {

        private ConciliationHeader headerField;

        private ConciliationTransaction[] financialTransactionsField;

        private object financialEventsField;

        private ConciliationTransaction2[] financialTransactionsAccountsField;

        private object financialEventAccountsField;

        private ConciliationPayment[] paymentsField;

        private ConciliationTrailer trailerField;

        /// <remarks/>
        public ConciliationHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transaction", IsNullable = false)]
        public ConciliationTransaction[] FinancialTransactions
        {
            get
            {
                return this.financialTransactionsField;
            }
            set
            {
                this.financialTransactionsField = value;
            }
        }

        /// <remarks/>
        public object FinancialEvents
        {
            get
            {
                return this.financialEventsField;
            }
            set
            {
                this.financialEventsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transaction", IsNullable = false)]
        public ConciliationTransaction2[] FinancialTransactionsAccounts
        {
            get
            {
                return this.financialTransactionsAccountsField;
            }
            set
            {
                this.financialTransactionsAccountsField = value;
            }
        }

        /// <remarks/>
        public object FinancialEventAccounts
        {
            get
            {
                return this.financialEventAccountsField;
            }
            set
            {
                this.financialEventAccountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Payment", IsNullable = false)]
        public ConciliationPayment[] Payments
        {
            get
            {
                return this.paymentsField;
            }
            set
            {
                this.paymentsField = value;
            }
        }

        /// <remarks/>
        public ConciliationTrailer Trailer
        {
            get
            {
                return this.trailerField;
            }
            set
            {
                this.trailerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationHeader
    {

        private ulong generationDateTimeField;

        private uint stoneCodeField;

        private decimal layoutVersionField;

        private int fileIdField;

        private uint referenceDateField;

        /// <remarks/>
        public ulong GenerationDateTime
        {
            get
            {
                return this.generationDateTimeField;
            }
            set
            {
                this.generationDateTimeField = value;
            }
        }

        /// <remarks/>
        public uint StoneCode
        {
            get
            {
                return this.stoneCodeField;
            }
            set
            {
                this.stoneCodeField = value;
            }
        }

        /// <remarks/>
        public decimal LayoutVersion
        {
            get
            {
                return this.layoutVersionField;
            }
            set
            {
                this.layoutVersionField = value;
            }
        }

        /// <remarks/>
        public int FileId
        {
            get
            {
                return this.fileIdField;
            }
            set
            {
                this.fileIdField = value;
            }
        }

        /// <remarks/>
        public uint ReferenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransaction
    {

        private ConciliationTransactionEvents eventsField;

        private ulong acquirerTransactionKeyField;

        private string initiatorTransactionKeyField;

        private ulong authorizationDateTimeField;

        private ulong captureLocalDateTimeField;

        private string internationalField;

        private int accountTypeField;

        private int installmentTypeField;

        private int numberOfInstallmentsField;

        private decimal authorizedAmountField;

        private decimal capturedAmountField;

        private ushort authorizationCurrencyCodeField;

        private string issuerAuthorizationCodeField;

        private int brandIdField;

        private string cardNumberField;

        private ConciliationTransactionPoi poiField;

        private int entryModeField;

        private ConciliationTransactionInstallment[] installmentsField;

        /// <remarks/>
        public ConciliationTransactionEvents Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        public ulong AcquirerTransactionKey
        {
            get
            {
                return this.acquirerTransactionKeyField;
            }
            set
            {
                this.acquirerTransactionKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string InitiatorTransactionKey
        {
            get
            {
                return this.initiatorTransactionKeyField;
            }
            set
            {
                this.initiatorTransactionKeyField = value;
            }
        }

        /// <remarks/>
        public ulong AuthorizationDateTime
        {
            get
            {
                return this.authorizationDateTimeField;
            }
            set
            {
                this.authorizationDateTimeField = value;
            }
        }

        /// <remarks/>
        public ulong CaptureLocalDateTime
        {
            get
            {
                return this.captureLocalDateTimeField;
            }
            set
            {
                this.captureLocalDateTimeField = value;
            }
        }

        /// <remarks/>
        public string International
        {
            get
            {
                return this.internationalField;
            }
            set
            {
                this.internationalField = value;
            }
        }

        /// <remarks/>
        public int AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        public int InstallmentType
        {
            get
            {
                return this.installmentTypeField;
            }
            set
            {
                this.installmentTypeField = value;
            }
        }

        /// <remarks/>
        public int NumberOfInstallments
        {
            get
            {
                return this.numberOfInstallmentsField;
            }
            set
            {
                this.numberOfInstallmentsField = value;
            }
        }

        /// <remarks/>
        public decimal AuthorizedAmount
        {
            get
            {
                return this.authorizedAmountField;
            }
            set
            {
                this.authorizedAmountField = value;
            }
        }

        /// <remarks/>
        public decimal CapturedAmount
        {
            get
            {
                return this.capturedAmountField;
            }
            set
            {
                this.capturedAmountField = value;
            }
        }

        /// <remarks/>
        public ushort AuthorizationCurrencyCode
        {
            get
            {
                return this.authorizationCurrencyCodeField;
            }
            set
            {
                this.authorizationCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        public string IssuerAuthorizationCode
        {
            get
            {
                return this.issuerAuthorizationCodeField;
            }
            set
            {
                this.issuerAuthorizationCodeField = value;
            }
        }

        /// <remarks/>
        public int BrandId
        {
            get
            {
                return this.brandIdField;
            }
            set
            {
                this.brandIdField = value;
            }
        }

        /// <remarks/>
        public string CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }

        /// <remarks/>
        public ConciliationTransactionPoi Poi
        {
            get
            {
                return this.poiField;
            }
            set
            {
                this.poiField = value;
            }
        }

        /// <remarks/>
        public int EntryMode
        {
            get
            {
                return this.entryModeField;
            }
            set
            {
                this.entryModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Installment", IsNullable = false)]
        public ConciliationTransactionInstallment[] Installments
        {
            get
            {
                return this.installmentsField;
            }
            set
            {
                this.installmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionEvents
    {

        private int cancellationChargesField;

        private int cancellationsField;

        private int capturesField;

        private int chargebackRefundsField;

        private int chargebacksField;

        private int paymentsField;

        /// <remarks/>
        public int CancellationCharges
        {
            get
            {
                return this.cancellationChargesField;
            }
            set
            {
                this.cancellationChargesField = value;
            }
        }

        /// <remarks/>
        public int Cancellations
        {
            get
            {
                return this.cancellationsField;
            }
            set
            {
                this.cancellationsField = value;
            }
        }

        /// <remarks/>
        public int Captures
        {
            get
            {
                return this.capturesField;
            }
            set
            {
                this.capturesField = value;
            }
        }

        /// <remarks/>
        public int ChargebackRefunds
        {
            get
            {
                return this.chargebackRefundsField;
            }
            set
            {
                this.chargebackRefundsField = value;
            }
        }

        /// <remarks/>
        public int Chargebacks
        {
            get
            {
                return this.chargebacksField;
            }
            set
            {
                this.chargebacksField = value;
            }
        }

        /// <remarks/>
        public int Payments
        {
            get
            {
                return this.paymentsField;
            }
            set
            {
                this.paymentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionPoi
    {

        private int poiTypeField;

        private uint serialNumberField;

        /// <remarks/>
        public int PoiType
        {
            get
            {
                return this.poiTypeField;
            }
            set
            {
                this.poiTypeField = value;
            }
        }

        /// <remarks/>
        public uint SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionInstallment
    {

        private int installmentNumberField;

        private decimal grossAmountField;

        private decimal netAmountField;

        private uint previsionPaymentDateField;

        /// <remarks/>
        public int InstallmentNumber
        {
            get
            {
                return this.installmentNumberField;
            }
            set
            {
                this.installmentNumberField = value;
            }
        }

        /// <remarks/>
        public decimal GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public decimal NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public uint PrevisionPaymentDate
        {
            get
            {
                return this.previsionPaymentDateField;
            }
            set
            {
                this.previsionPaymentDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransaction2
    {

        private ConciliationTransactionEvents1 eventsField;

        private ulong acquirerTransactionKeyField;

        private string initiatorTransactionKeyField;

        private ulong authorizationDateTimeField;

        private ulong captureLocalDateTimeField;

        private ConciliationTransactionPoi1 poiField;

        private int entryModeField;

        private ConciliationTransactionInstallments installmentsField;

        /// <remarks/>
        public ConciliationTransactionEvents1 Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        public ulong AcquirerTransactionKey
        {
            get
            {
                return this.acquirerTransactionKeyField;
            }
            set
            {
                this.acquirerTransactionKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string InitiatorTransactionKey
        {
            get
            {
                return this.initiatorTransactionKeyField;
            }
            set
            {
                this.initiatorTransactionKeyField = value;
            }
        }

        /// <remarks/>
        public ulong AuthorizationDateTime
        {
            get
            {
                return this.authorizationDateTimeField;
            }
            set
            {
                this.authorizationDateTimeField = value;
            }
        }

        /// <remarks/>
        public ulong CaptureLocalDateTime
        {
            get
            {
                return this.captureLocalDateTimeField;
            }
            set
            {
                this.captureLocalDateTimeField = value;
            }
        }

        /// <remarks/>
        public ConciliationTransactionPoi1 Poi
        {
            get
            {
                return this.poiField;
            }
            set
            {
                this.poiField = value;
            }
        }

        /// <remarks/>
        public int EntryMode
        {
            get
            {
                return this.entryModeField;
            }
            set
            {
                this.entryModeField = value;
            }
        }

        /// <remarks/>
        public ConciliationTransactionInstallments Installments
        {
            get
            {
                return this.installmentsField;
            }
            set
            {
                this.installmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionEvents1
    {

        private int cancellationChargesField;

        private int cancellationsField;

        private int capturesField;

        private int chargebackRefundsField;

        private int chargebacksField;

        private int paymentsField;

        /// <remarks/>
        public int CancellationCharges
        {
            get
            {
                return this.cancellationChargesField;
            }
            set
            {
                this.cancellationChargesField = value;
            }
        }

        /// <remarks/>
        public int Cancellations
        {
            get
            {
                return this.cancellationsField;
            }
            set
            {
                this.cancellationsField = value;
            }
        }

        /// <remarks/>
        public int Captures
        {
            get
            {
                return this.capturesField;
            }
            set
            {
                this.capturesField = value;
            }
        }

        /// <remarks/>
        public int ChargebackRefunds
        {
            get
            {
                return this.chargebackRefundsField;
            }
            set
            {
                this.chargebackRefundsField = value;
            }
        }

        /// <remarks/>
        public int Chargebacks
        {
            get
            {
                return this.chargebacksField;
            }
            set
            {
                this.chargebacksField = value;
            }
        }

        /// <remarks/>
        public int Payments
        {
            get
            {
                return this.paymentsField;
            }
            set
            {
                this.paymentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionPoi1
    {

        private int poiTypeField;

        private uint serialNumberField;

        /// <remarks/>
        public int PoiType
        {
            get
            {
                return this.poiTypeField;
            }
            set
            {
                this.poiTypeField = value;
            }
        }

        /// <remarks/>
        public uint SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionInstallments
    {

        private ConciliationTransactionInstallmentsInstallment installmentField;

        /// <remarks/>
        public ConciliationTransactionInstallmentsInstallment Installment
        {
            get
            {
                return this.installmentField;
            }
            set
            {
                this.installmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTransactionInstallmentsInstallment
    {

        private int installmentNumberField;

        private decimal grossAmountField;

        private decimal netAmountField;

        private uint paymentDateField;

        private decimal advanceRateAmountField;

        private bool advanceRateAmountFieldSpecified;

        private uint advancedReceivableOriginalPaymentDateField;

        private bool advancedReceivableOriginalPaymentDateFieldSpecified;

        private uint paymentIdField;

        /// <remarks/>
        public int InstallmentNumber
        {
            get
            {
                return this.installmentNumberField;
            }
            set
            {
                this.installmentNumberField = value;
            }
        }

        /// <remarks/>
        public decimal GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public decimal NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public uint PaymentDate
        {
            get
            {
                return this.paymentDateField;
            }
            set
            {
                this.paymentDateField = value;
            }
        }

        /// <remarks/>
        public decimal AdvanceRateAmount
        {
            get
            {
                return this.advanceRateAmountField;
            }
            set
            {
                this.advanceRateAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvanceRateAmountSpecified
        {
            get
            {
                return this.advanceRateAmountFieldSpecified;
            }
            set
            {
                this.advanceRateAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint AdvancedReceivableOriginalPaymentDate
        {
            get
            {
                return this.advancedReceivableOriginalPaymentDateField;
            }
            set
            {
                this.advancedReceivableOriginalPaymentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvancedReceivableOriginalPaymentDateSpecified
        {
            get
            {
                return this.advancedReceivableOriginalPaymentDateFieldSpecified;
            }
            set
            {
                this.advancedReceivableOriginalPaymentDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint PaymentId
        {
            get
            {
                return this.paymentIdField;
            }
            set
            {
                this.paymentIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationPayment
    {

        private uint idField;

        private int walletTypeIdField;

        private decimal totalAmountField;

        private decimal totalFinancialAccountsAmountField;

        private decimal lastNegativeAmountField;

        private ConciliationPaymentFavoredBankAccount favoredBankAccountField;

        /// <remarks/>
        public uint Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public int WalletTypeId
        {
            get
            {
                return this.walletTypeIdField;
            }
            set
            {
                this.walletTypeIdField = value;
            }
        }

        /// <remarks/>
        public decimal TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        public decimal TotalFinancialAccountsAmount
        {
            get
            {
                return this.totalFinancialAccountsAmountField;
            }
            set
            {
                this.totalFinancialAccountsAmountField = value;
            }
        }

        /// <remarks/>
        public decimal LastNegativeAmount
        {
            get
            {
                return this.lastNegativeAmountField;
            }
            set
            {
                this.lastNegativeAmountField = value;
            }
        }

        /// <remarks/>
        public ConciliationPaymentFavoredBankAccount FavoredBankAccount
        {
            get
            {
                return this.favoredBankAccountField;
            }
            set
            {
                this.favoredBankAccountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationPaymentFavoredBankAccount
    {

        private ushort bankCodeField;

        private int bankBranchField;

        private uint bankAccountNumberField;

        /// <remarks/>
        public ushort BankCode
        {
            get
            {
                return this.bankCodeField;
            }
            set
            {
                this.bankCodeField = value;
            }
        }

        /// <remarks/>
        public int BankBranch
        {
            get
            {
                return this.bankBranchField;
            }
            set
            {
                this.bankBranchField = value;
            }
        }

        /// <remarks/>
        public uint BankAccountNumber
        {
            get
            {
                return this.bankAccountNumberField;
            }
            set
            {
                this.bankAccountNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConciliationTrailer
    {

        private int capturedTransactionsQuantityField;

        private int canceledTransactionsQuantityField;

        private ushort paidInstallmentsQuantityField;

        private int chargedCancellationsQuantityField;

        private int chargebacksQuantityField;

        private int chargebacksRefundQuantityField;

        private int chargedChargebacksQuantityField;

        private int paidChargebacksRefundQuantityField;

        private int paidEventsQuantityField;

        private int chargedEventsQuantityField;

        /// <remarks/>
        public int CapturedTransactionsQuantity
        {
            get
            {
                return this.capturedTransactionsQuantityField;
            }
            set
            {
                this.capturedTransactionsQuantityField = value;
            }
        }

        /// <remarks/>
        public int CanceledTransactionsQuantity
        {
            get
            {
                return this.canceledTransactionsQuantityField;
            }
            set
            {
                this.canceledTransactionsQuantityField = value;
            }
        }

        /// <remarks/>
        public ushort PaidInstallmentsQuantity
        {
            get
            {
                return this.paidInstallmentsQuantityField;
            }
            set
            {
                this.paidInstallmentsQuantityField = value;
            }
        }

        /// <remarks/>
        public int ChargedCancellationsQuantity
        {
            get
            {
                return this.chargedCancellationsQuantityField;
            }
            set
            {
                this.chargedCancellationsQuantityField = value;
            }
        }

        /// <remarks/>
        public int ChargebacksQuantity
        {
            get
            {
                return this.chargebacksQuantityField;
            }
            set
            {
                this.chargebacksQuantityField = value;
            }
        }

        /// <remarks/>
        public int ChargebacksRefundQuantity
        {
            get
            {
                return this.chargebacksRefundQuantityField;
            }
            set
            {
                this.chargebacksRefundQuantityField = value;
            }
        }

        /// <remarks/>
        public int ChargedChargebacksQuantity
        {
            get
            {
                return this.chargedChargebacksQuantityField;
            }
            set
            {
                this.chargedChargebacksQuantityField = value;
            }
        }

        /// <remarks/>
        public int PaidChargebacksRefundQuantity
        {
            get
            {
                return this.paidChargebacksRefundQuantityField;
            }
            set
            {
                this.paidChargebacksRefundQuantityField = value;
            }
        }

        /// <remarks/>
        public int PaidEventsQuantity
        {
            get
            {
                return this.paidEventsQuantityField;
            }
            set
            {
                this.paidEventsQuantityField = value;
            }
        }

        /// <remarks/>
        public int ChargedEventsQuantity
        {
            get
            {
                return this.chargedEventsQuantityField;
            }
            set
            {
                this.chargedEventsQuantityField = value;
            }
        }
    }


}
