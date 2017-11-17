/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractMcaw
    /// </summary>
    [DataContract]
    public partial class LoanContractMcaw :  IEquatable<LoanContractMcaw>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AdequacyOfAvailableAssetsType
        /// </summary>
        [DataMember(Name="adequacyOfAvailableAssetsType", EmitDefaultValue=false)]
        public string AdequacyOfAvailableAssetsType { get; set; }

        /// <summary>
        /// Gets or Sets AdequacyOfEffectiveIncomeType
        /// </summary>
        [DataMember(Name="adequacyOfEffectiveIncomeType", EmitDefaultValue=false)]
        public string AdequacyOfEffectiveIncomeType { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPurchasePrice
        /// </summary>
        [DataMember(Name="adjustedPurchasePrice", EmitDefaultValue=false)]
        public double? AdjustedPurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets AppraisedValue1
        /// </summary>
        [DataMember(Name="appraisedValue1", EmitDefaultValue=false)]
        public double? AppraisedValue1 { get; set; }

        /// <summary>
        /// Gets or Sets AppraisedValue2
        /// </summary>
        [DataMember(Name="appraisedValue2", EmitDefaultValue=false)]
        public double? AppraisedValue2 { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerPaidClosingCost
        /// </summary>
        [DataMember(Name="borrowerPaidClosingCost", EmitDefaultValue=false)]
        public double? BorrowerPaidClosingCost { get; set; }

        /// <summary>
        /// Gets or Sets CalculatedMortgageAmount
        /// </summary>
        [DataMember(Name="calculatedMortgageAmount", EmitDefaultValue=false)]
        public double? CalculatedMortgageAmount { get; set; }

        /// <summary>
        /// Gets or Sets CashReserves
        /// </summary>
        [DataMember(Name="cashReserves", EmitDefaultValue=false)]
        public double? CashReserves { get; set; }

        /// <summary>
        /// Gets or Sets ConstructionType
        /// </summary>
        [DataMember(Name="constructionType", EmitDefaultValue=false)]
        public string ConstructionType { get; set; }

        /// <summary>
        /// Gets or Sets ContractSalesPrice
        /// </summary>
        [DataMember(Name="contractSalesPrice", EmitDefaultValue=false)]
        public double? ContractSalesPrice { get; set; }

        /// <summary>
        /// Gets or Sets CreditCharacteristicsType
        /// </summary>
        [DataMember(Name="creditCharacteristicsType", EmitDefaultValue=false)]
        public string CreditCharacteristicsType { get; set; }

        /// <summary>
        /// Gets or Sets EquityToExSpouse
        /// </summary>
        [DataMember(Name="equityToExSpouse", EmitDefaultValue=false)]
        public double? EquityToExSpouse { get; set; }

        /// <summary>
        /// Gets or Sets FhaMaxLoanAmount
        /// </summary>
        [DataMember(Name="fhaMaxLoanAmount", EmitDefaultValue=false)]
        public double? FhaMaxLoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets FhaUnderwriterChumsId
        /// </summary>
        [DataMember(Name="fhaUnderwriterChumsId", EmitDefaultValue=false)]
        public string FhaUnderwriterChumsId { get; set; }

        /// <summary>
        /// Gets or Sets GiftFundsSource
        /// </summary>
        [DataMember(Name="giftFundsSource", EmitDefaultValue=false)]
        public string GiftFundsSource { get; set; }

        /// <summary>
        /// Gets or Sets LesserSalesPrice
        /// </summary>
        [DataMember(Name="lesserSalesPrice", EmitDefaultValue=false)]
        public double? LesserSalesPrice { get; set; }

        /// <summary>
        /// Gets or Sets Ltv1
        /// </summary>
        [DataMember(Name="ltv1", EmitDefaultValue=false)]
        public double? Ltv1 { get; set; }

        /// <summary>
        /// Gets or Sets Ltv2
        /// </summary>
        [DataMember(Name="ltv2", EmitDefaultValue=false)]
        public double? Ltv2 { get; set; }

        /// <summary>
        /// Gets or Sets MortgageAmount
        /// </summary>
        [DataMember(Name="mortgageAmount", EmitDefaultValue=false)]
        public double? MortgageAmount { get; set; }

        /// <summary>
        /// Gets or Sets MortgageAmountPercent
        /// </summary>
        [DataMember(Name="mortgageAmountPercent", EmitDefaultValue=false)]
        public double? MortgageAmountPercent { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBasisPurchase
        /// </summary>
        [DataMember(Name="mortgageBasisPurchase", EmitDefaultValue=false)]
        public double? MortgageBasisPurchase { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBasisRefinance
        /// </summary>
        [DataMember(Name="mortgageBasisRefinance", EmitDefaultValue=false)]
        public double? MortgageBasisRefinance { get; set; }

        /// <summary>
        /// Gets or Sets PaidType1
        /// </summary>
        [DataMember(Name="paidType1", EmitDefaultValue=false)]
        public string PaidType1 { get; set; }

        /// <summary>
        /// Gets or Sets PaidType2
        /// </summary>
        [DataMember(Name="paidType2", EmitDefaultValue=false)]
        public string PaidType2 { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalBalance
        /// </summary>
        [DataMember(Name="principalBalance", EmitDefaultValue=false)]
        public double? PrincipalBalance { get; set; }

        /// <summary>
        /// Gets or Sets RefinanceType
        /// </summary>
        [DataMember(Name="refinanceType", EmitDefaultValue=false)]
        public string RefinanceType { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets RepairsAndImprovements
        /// </summary>
        [DataMember(Name="repairsAndImprovements", EmitDefaultValue=false)]
        public double? RepairsAndImprovements { get; set; }

        /// <summary>
        /// Gets or Sets RepairsAndImprovementsDescription
        /// </summary>
        [DataMember(Name="repairsAndImprovementsDescription", EmitDefaultValue=false)]
        public string RepairsAndImprovementsDescription { get; set; }

        /// <summary>
        /// Gets or Sets RepairsRequiredByAppraiser
        /// </summary>
        [DataMember(Name="repairsRequiredByAppraiser", EmitDefaultValue=false)]
        public double? RepairsRequiredByAppraiser { get; set; }

        /// <summary>
        /// Gets or Sets RequiredInvestment
        /// </summary>
        [DataMember(Name="requiredInvestment", EmitDefaultValue=false)]
        public double? RequiredInvestment { get; set; }

        /// <summary>
        /// Gets or Sets RequirementAdjustment
        /// </summary>
        [DataMember(Name="requirementAdjustment", EmitDefaultValue=false)]
        public double? RequirementAdjustment { get; set; }

        /// <summary>
        /// Gets or Sets RoundTo50Indicator
        /// </summary>
        [DataMember(Name="roundTo50Indicator", EmitDefaultValue=false)]
        public bool? RoundTo50Indicator { get; set; }

        /// <summary>
        /// Gets or Sets SeasonedSubordinateLiens
        /// </summary>
        [DataMember(Name="seasonedSubordinateLiens", EmitDefaultValue=false)]
        public double? SeasonedSubordinateLiens { get; set; }

        /// <summary>
        /// Gets or Sets SecondMortgageSource
        /// </summary>
        [DataMember(Name="secondMortgageSource", EmitDefaultValue=false)]
        public string SecondMortgageSource { get; set; }

        /// <summary>
        /// Gets or Sets SixPercentOfLineA1
        /// </summary>
        [DataMember(Name="sixPercentOfLineA1", EmitDefaultValue=false)]
        public double? SixPercentOfLineA1 { get; set; }

        /// <summary>
        /// Gets or Sets MaximumSellerContribution4Percent
        /// </summary>
        [DataMember(Name="maximumSellerContribution4Percent", EmitDefaultValue=false)]
        public double? MaximumSellerContribution4Percent { get; set; }

        /// <summary>
        /// Gets or Sets StabilityOfEffectiveIncomeType
        /// </summary>
        [DataMember(Name="stabilityOfEffectiveIncomeType", EmitDefaultValue=false)]
        public string StabilityOfEffectiveIncomeType { get; set; }

        /// <summary>
        /// Gets or Sets StatutoryInvestment
        /// </summary>
        [DataMember(Name="statutoryInvestment", EmitDefaultValue=false)]
        public double? StatutoryInvestment { get; set; }

        /// <summary>
        /// Gets or Sets ToBePaidAmount
        /// </summary>
        [DataMember(Name="toBePaidAmount", EmitDefaultValue=false)]
        public double? ToBePaidAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCashToClose
        /// </summary>
        [DataMember(Name="totalCashToClose", EmitDefaultValue=false)]
        public double? TotalCashToClose { get; set; }

        /// <summary>
        /// Gets or Sets TotalRequirements
        /// </summary>
        [DataMember(Name="totalRequirements", EmitDefaultValue=false)]
        public double? TotalRequirements { get; set; }

        /// <summary>
        /// Gets or Sets TotalSellerContribution
        /// </summary>
        [DataMember(Name="totalSellerContribution", EmitDefaultValue=false)]
        public double? TotalSellerContribution { get; set; }

        /// <summary>
        /// Gets or Sets UnadjustedAcquisition
        /// </summary>
        [DataMember(Name="unadjustedAcquisition", EmitDefaultValue=false)]
        public double? UnadjustedAcquisition { get; set; }

        /// <summary>
        /// Gets or Sets Use85PercentRuleIndicator
        /// </summary>
        [DataMember(Name="use85PercentRuleIndicator", EmitDefaultValue=false)]
        public bool? Use85PercentRuleIndicator { get; set; }

        /// <summary>
        /// Gets or Sets RepairsImprovementAmount
        /// </summary>
        [DataMember(Name="repairsImprovementAmount", EmitDefaultValue=false)]
        public double? RepairsImprovementAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractMcaw {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdequacyOfAvailableAssetsType: ").Append(AdequacyOfAvailableAssetsType).Append("\n");
            sb.Append("  AdequacyOfEffectiveIncomeType: ").Append(AdequacyOfEffectiveIncomeType).Append("\n");
            sb.Append("  AdjustedPurchasePrice: ").Append(AdjustedPurchasePrice).Append("\n");
            sb.Append("  AppraisedValue1: ").Append(AppraisedValue1).Append("\n");
            sb.Append("  AppraisedValue2: ").Append(AppraisedValue2).Append("\n");
            sb.Append("  BorrowerPaidClosingCost: ").Append(BorrowerPaidClosingCost).Append("\n");
            sb.Append("  CalculatedMortgageAmount: ").Append(CalculatedMortgageAmount).Append("\n");
            sb.Append("  CashReserves: ").Append(CashReserves).Append("\n");
            sb.Append("  ConstructionType: ").Append(ConstructionType).Append("\n");
            sb.Append("  ContractSalesPrice: ").Append(ContractSalesPrice).Append("\n");
            sb.Append("  CreditCharacteristicsType: ").Append(CreditCharacteristicsType).Append("\n");
            sb.Append("  EquityToExSpouse: ").Append(EquityToExSpouse).Append("\n");
            sb.Append("  FhaMaxLoanAmount: ").Append(FhaMaxLoanAmount).Append("\n");
            sb.Append("  FhaUnderwriterChumsId: ").Append(FhaUnderwriterChumsId).Append("\n");
            sb.Append("  GiftFundsSource: ").Append(GiftFundsSource).Append("\n");
            sb.Append("  LesserSalesPrice: ").Append(LesserSalesPrice).Append("\n");
            sb.Append("  Ltv1: ").Append(Ltv1).Append("\n");
            sb.Append("  Ltv2: ").Append(Ltv2).Append("\n");
            sb.Append("  MortgageAmount: ").Append(MortgageAmount).Append("\n");
            sb.Append("  MortgageAmountPercent: ").Append(MortgageAmountPercent).Append("\n");
            sb.Append("  MortgageBasisPurchase: ").Append(MortgageBasisPurchase).Append("\n");
            sb.Append("  MortgageBasisRefinance: ").Append(MortgageBasisRefinance).Append("\n");
            sb.Append("  PaidType1: ").Append(PaidType1).Append("\n");
            sb.Append("  PaidType2: ").Append(PaidType2).Append("\n");
            sb.Append("  PrincipalBalance: ").Append(PrincipalBalance).Append("\n");
            sb.Append("  RefinanceType: ").Append(RefinanceType).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  RepairsAndImprovements: ").Append(RepairsAndImprovements).Append("\n");
            sb.Append("  RepairsAndImprovementsDescription: ").Append(RepairsAndImprovementsDescription).Append("\n");
            sb.Append("  RepairsRequiredByAppraiser: ").Append(RepairsRequiredByAppraiser).Append("\n");
            sb.Append("  RequiredInvestment: ").Append(RequiredInvestment).Append("\n");
            sb.Append("  RequirementAdjustment: ").Append(RequirementAdjustment).Append("\n");
            sb.Append("  RoundTo50Indicator: ").Append(RoundTo50Indicator).Append("\n");
            sb.Append("  SeasonedSubordinateLiens: ").Append(SeasonedSubordinateLiens).Append("\n");
            sb.Append("  SecondMortgageSource: ").Append(SecondMortgageSource).Append("\n");
            sb.Append("  SixPercentOfLineA1: ").Append(SixPercentOfLineA1).Append("\n");
            sb.Append("  MaximumSellerContribution4Percent: ").Append(MaximumSellerContribution4Percent).Append("\n");
            sb.Append("  StabilityOfEffectiveIncomeType: ").Append(StabilityOfEffectiveIncomeType).Append("\n");
            sb.Append("  StatutoryInvestment: ").Append(StatutoryInvestment).Append("\n");
            sb.Append("  ToBePaidAmount: ").Append(ToBePaidAmount).Append("\n");
            sb.Append("  TotalCashToClose: ").Append(TotalCashToClose).Append("\n");
            sb.Append("  TotalRequirements: ").Append(TotalRequirements).Append("\n");
            sb.Append("  TotalSellerContribution: ").Append(TotalSellerContribution).Append("\n");
            sb.Append("  UnadjustedAcquisition: ").Append(UnadjustedAcquisition).Append("\n");
            sb.Append("  Use85PercentRuleIndicator: ").Append(Use85PercentRuleIndicator).Append("\n");
            sb.Append("  RepairsImprovementAmount: ").Append(RepairsImprovementAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractMcaw);
        }

        /// <summary>
        /// Returns true if LoanContractMcaw instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractMcaw to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractMcaw input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AdequacyOfAvailableAssetsType == input.AdequacyOfAvailableAssetsType ||
                    (this.AdequacyOfAvailableAssetsType != null &&
                    this.AdequacyOfAvailableAssetsType.Equals(input.AdequacyOfAvailableAssetsType))
                ) && 
                (
                    this.AdequacyOfEffectiveIncomeType == input.AdequacyOfEffectiveIncomeType ||
                    (this.AdequacyOfEffectiveIncomeType != null &&
                    this.AdequacyOfEffectiveIncomeType.Equals(input.AdequacyOfEffectiveIncomeType))
                ) && 
                (
                    this.AdjustedPurchasePrice == input.AdjustedPurchasePrice ||
                    (this.AdjustedPurchasePrice != null &&
                    this.AdjustedPurchasePrice.Equals(input.AdjustedPurchasePrice))
                ) && 
                (
                    this.AppraisedValue1 == input.AppraisedValue1 ||
                    (this.AppraisedValue1 != null &&
                    this.AppraisedValue1.Equals(input.AppraisedValue1))
                ) && 
                (
                    this.AppraisedValue2 == input.AppraisedValue2 ||
                    (this.AppraisedValue2 != null &&
                    this.AppraisedValue2.Equals(input.AppraisedValue2))
                ) && 
                (
                    this.BorrowerPaidClosingCost == input.BorrowerPaidClosingCost ||
                    (this.BorrowerPaidClosingCost != null &&
                    this.BorrowerPaidClosingCost.Equals(input.BorrowerPaidClosingCost))
                ) && 
                (
                    this.CalculatedMortgageAmount == input.CalculatedMortgageAmount ||
                    (this.CalculatedMortgageAmount != null &&
                    this.CalculatedMortgageAmount.Equals(input.CalculatedMortgageAmount))
                ) && 
                (
                    this.CashReserves == input.CashReserves ||
                    (this.CashReserves != null &&
                    this.CashReserves.Equals(input.CashReserves))
                ) && 
                (
                    this.ConstructionType == input.ConstructionType ||
                    (this.ConstructionType != null &&
                    this.ConstructionType.Equals(input.ConstructionType))
                ) && 
                (
                    this.ContractSalesPrice == input.ContractSalesPrice ||
                    (this.ContractSalesPrice != null &&
                    this.ContractSalesPrice.Equals(input.ContractSalesPrice))
                ) && 
                (
                    this.CreditCharacteristicsType == input.CreditCharacteristicsType ||
                    (this.CreditCharacteristicsType != null &&
                    this.CreditCharacteristicsType.Equals(input.CreditCharacteristicsType))
                ) && 
                (
                    this.EquityToExSpouse == input.EquityToExSpouse ||
                    (this.EquityToExSpouse != null &&
                    this.EquityToExSpouse.Equals(input.EquityToExSpouse))
                ) && 
                (
                    this.FhaMaxLoanAmount == input.FhaMaxLoanAmount ||
                    (this.FhaMaxLoanAmount != null &&
                    this.FhaMaxLoanAmount.Equals(input.FhaMaxLoanAmount))
                ) && 
                (
                    this.FhaUnderwriterChumsId == input.FhaUnderwriterChumsId ||
                    (this.FhaUnderwriterChumsId != null &&
                    this.FhaUnderwriterChumsId.Equals(input.FhaUnderwriterChumsId))
                ) && 
                (
                    this.GiftFundsSource == input.GiftFundsSource ||
                    (this.GiftFundsSource != null &&
                    this.GiftFundsSource.Equals(input.GiftFundsSource))
                ) && 
                (
                    this.LesserSalesPrice == input.LesserSalesPrice ||
                    (this.LesserSalesPrice != null &&
                    this.LesserSalesPrice.Equals(input.LesserSalesPrice))
                ) && 
                (
                    this.Ltv1 == input.Ltv1 ||
                    (this.Ltv1 != null &&
                    this.Ltv1.Equals(input.Ltv1))
                ) && 
                (
                    this.Ltv2 == input.Ltv2 ||
                    (this.Ltv2 != null &&
                    this.Ltv2.Equals(input.Ltv2))
                ) && 
                (
                    this.MortgageAmount == input.MortgageAmount ||
                    (this.MortgageAmount != null &&
                    this.MortgageAmount.Equals(input.MortgageAmount))
                ) && 
                (
                    this.MortgageAmountPercent == input.MortgageAmountPercent ||
                    (this.MortgageAmountPercent != null &&
                    this.MortgageAmountPercent.Equals(input.MortgageAmountPercent))
                ) && 
                (
                    this.MortgageBasisPurchase == input.MortgageBasisPurchase ||
                    (this.MortgageBasisPurchase != null &&
                    this.MortgageBasisPurchase.Equals(input.MortgageBasisPurchase))
                ) && 
                (
                    this.MortgageBasisRefinance == input.MortgageBasisRefinance ||
                    (this.MortgageBasisRefinance != null &&
                    this.MortgageBasisRefinance.Equals(input.MortgageBasisRefinance))
                ) && 
                (
                    this.PaidType1 == input.PaidType1 ||
                    (this.PaidType1 != null &&
                    this.PaidType1.Equals(input.PaidType1))
                ) && 
                (
                    this.PaidType2 == input.PaidType2 ||
                    (this.PaidType2 != null &&
                    this.PaidType2.Equals(input.PaidType2))
                ) && 
                (
                    this.PrincipalBalance == input.PrincipalBalance ||
                    (this.PrincipalBalance != null &&
                    this.PrincipalBalance.Equals(input.PrincipalBalance))
                ) && 
                (
                    this.RefinanceType == input.RefinanceType ||
                    (this.RefinanceType != null &&
                    this.RefinanceType.Equals(input.RefinanceType))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.RepairsAndImprovements == input.RepairsAndImprovements ||
                    (this.RepairsAndImprovements != null &&
                    this.RepairsAndImprovements.Equals(input.RepairsAndImprovements))
                ) && 
                (
                    this.RepairsAndImprovementsDescription == input.RepairsAndImprovementsDescription ||
                    (this.RepairsAndImprovementsDescription != null &&
                    this.RepairsAndImprovementsDescription.Equals(input.RepairsAndImprovementsDescription))
                ) && 
                (
                    this.RepairsRequiredByAppraiser == input.RepairsRequiredByAppraiser ||
                    (this.RepairsRequiredByAppraiser != null &&
                    this.RepairsRequiredByAppraiser.Equals(input.RepairsRequiredByAppraiser))
                ) && 
                (
                    this.RequiredInvestment == input.RequiredInvestment ||
                    (this.RequiredInvestment != null &&
                    this.RequiredInvestment.Equals(input.RequiredInvestment))
                ) && 
                (
                    this.RequirementAdjustment == input.RequirementAdjustment ||
                    (this.RequirementAdjustment != null &&
                    this.RequirementAdjustment.Equals(input.RequirementAdjustment))
                ) && 
                (
                    this.RoundTo50Indicator == input.RoundTo50Indicator ||
                    (this.RoundTo50Indicator != null &&
                    this.RoundTo50Indicator.Equals(input.RoundTo50Indicator))
                ) && 
                (
                    this.SeasonedSubordinateLiens == input.SeasonedSubordinateLiens ||
                    (this.SeasonedSubordinateLiens != null &&
                    this.SeasonedSubordinateLiens.Equals(input.SeasonedSubordinateLiens))
                ) && 
                (
                    this.SecondMortgageSource == input.SecondMortgageSource ||
                    (this.SecondMortgageSource != null &&
                    this.SecondMortgageSource.Equals(input.SecondMortgageSource))
                ) && 
                (
                    this.SixPercentOfLineA1 == input.SixPercentOfLineA1 ||
                    (this.SixPercentOfLineA1 != null &&
                    this.SixPercentOfLineA1.Equals(input.SixPercentOfLineA1))
                ) && 
                (
                    this.MaximumSellerContribution4Percent == input.MaximumSellerContribution4Percent ||
                    (this.MaximumSellerContribution4Percent != null &&
                    this.MaximumSellerContribution4Percent.Equals(input.MaximumSellerContribution4Percent))
                ) && 
                (
                    this.StabilityOfEffectiveIncomeType == input.StabilityOfEffectiveIncomeType ||
                    (this.StabilityOfEffectiveIncomeType != null &&
                    this.StabilityOfEffectiveIncomeType.Equals(input.StabilityOfEffectiveIncomeType))
                ) && 
                (
                    this.StatutoryInvestment == input.StatutoryInvestment ||
                    (this.StatutoryInvestment != null &&
                    this.StatutoryInvestment.Equals(input.StatutoryInvestment))
                ) && 
                (
                    this.ToBePaidAmount == input.ToBePaidAmount ||
                    (this.ToBePaidAmount != null &&
                    this.ToBePaidAmount.Equals(input.ToBePaidAmount))
                ) && 
                (
                    this.TotalCashToClose == input.TotalCashToClose ||
                    (this.TotalCashToClose != null &&
                    this.TotalCashToClose.Equals(input.TotalCashToClose))
                ) && 
                (
                    this.TotalRequirements == input.TotalRequirements ||
                    (this.TotalRequirements != null &&
                    this.TotalRequirements.Equals(input.TotalRequirements))
                ) && 
                (
                    this.TotalSellerContribution == input.TotalSellerContribution ||
                    (this.TotalSellerContribution != null &&
                    this.TotalSellerContribution.Equals(input.TotalSellerContribution))
                ) && 
                (
                    this.UnadjustedAcquisition == input.UnadjustedAcquisition ||
                    (this.UnadjustedAcquisition != null &&
                    this.UnadjustedAcquisition.Equals(input.UnadjustedAcquisition))
                ) && 
                (
                    this.Use85PercentRuleIndicator == input.Use85PercentRuleIndicator ||
                    (this.Use85PercentRuleIndicator != null &&
                    this.Use85PercentRuleIndicator.Equals(input.Use85PercentRuleIndicator))
                ) && 
                (
                    this.RepairsImprovementAmount == input.RepairsImprovementAmount ||
                    (this.RepairsImprovementAmount != null &&
                    this.RepairsImprovementAmount.Equals(input.RepairsImprovementAmount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AdequacyOfAvailableAssetsType != null)
                    hashCode = hashCode * 59 + this.AdequacyOfAvailableAssetsType.GetHashCode();
                if (this.AdequacyOfEffectiveIncomeType != null)
                    hashCode = hashCode * 59 + this.AdequacyOfEffectiveIncomeType.GetHashCode();
                if (this.AdjustedPurchasePrice != null)
                    hashCode = hashCode * 59 + this.AdjustedPurchasePrice.GetHashCode();
                if (this.AppraisedValue1 != null)
                    hashCode = hashCode * 59 + this.AppraisedValue1.GetHashCode();
                if (this.AppraisedValue2 != null)
                    hashCode = hashCode * 59 + this.AppraisedValue2.GetHashCode();
                if (this.BorrowerPaidClosingCost != null)
                    hashCode = hashCode * 59 + this.BorrowerPaidClosingCost.GetHashCode();
                if (this.CalculatedMortgageAmount != null)
                    hashCode = hashCode * 59 + this.CalculatedMortgageAmount.GetHashCode();
                if (this.CashReserves != null)
                    hashCode = hashCode * 59 + this.CashReserves.GetHashCode();
                if (this.ConstructionType != null)
                    hashCode = hashCode * 59 + this.ConstructionType.GetHashCode();
                if (this.ContractSalesPrice != null)
                    hashCode = hashCode * 59 + this.ContractSalesPrice.GetHashCode();
                if (this.CreditCharacteristicsType != null)
                    hashCode = hashCode * 59 + this.CreditCharacteristicsType.GetHashCode();
                if (this.EquityToExSpouse != null)
                    hashCode = hashCode * 59 + this.EquityToExSpouse.GetHashCode();
                if (this.FhaMaxLoanAmount != null)
                    hashCode = hashCode * 59 + this.FhaMaxLoanAmount.GetHashCode();
                if (this.FhaUnderwriterChumsId != null)
                    hashCode = hashCode * 59 + this.FhaUnderwriterChumsId.GetHashCode();
                if (this.GiftFundsSource != null)
                    hashCode = hashCode * 59 + this.GiftFundsSource.GetHashCode();
                if (this.LesserSalesPrice != null)
                    hashCode = hashCode * 59 + this.LesserSalesPrice.GetHashCode();
                if (this.Ltv1 != null)
                    hashCode = hashCode * 59 + this.Ltv1.GetHashCode();
                if (this.Ltv2 != null)
                    hashCode = hashCode * 59 + this.Ltv2.GetHashCode();
                if (this.MortgageAmount != null)
                    hashCode = hashCode * 59 + this.MortgageAmount.GetHashCode();
                if (this.MortgageAmountPercent != null)
                    hashCode = hashCode * 59 + this.MortgageAmountPercent.GetHashCode();
                if (this.MortgageBasisPurchase != null)
                    hashCode = hashCode * 59 + this.MortgageBasisPurchase.GetHashCode();
                if (this.MortgageBasisRefinance != null)
                    hashCode = hashCode * 59 + this.MortgageBasisRefinance.GetHashCode();
                if (this.PaidType1 != null)
                    hashCode = hashCode * 59 + this.PaidType1.GetHashCode();
                if (this.PaidType2 != null)
                    hashCode = hashCode * 59 + this.PaidType2.GetHashCode();
                if (this.PrincipalBalance != null)
                    hashCode = hashCode * 59 + this.PrincipalBalance.GetHashCode();
                if (this.RefinanceType != null)
                    hashCode = hashCode * 59 + this.RefinanceType.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.RepairsAndImprovements != null)
                    hashCode = hashCode * 59 + this.RepairsAndImprovements.GetHashCode();
                if (this.RepairsAndImprovementsDescription != null)
                    hashCode = hashCode * 59 + this.RepairsAndImprovementsDescription.GetHashCode();
                if (this.RepairsRequiredByAppraiser != null)
                    hashCode = hashCode * 59 + this.RepairsRequiredByAppraiser.GetHashCode();
                if (this.RequiredInvestment != null)
                    hashCode = hashCode * 59 + this.RequiredInvestment.GetHashCode();
                if (this.RequirementAdjustment != null)
                    hashCode = hashCode * 59 + this.RequirementAdjustment.GetHashCode();
                if (this.RoundTo50Indicator != null)
                    hashCode = hashCode * 59 + this.RoundTo50Indicator.GetHashCode();
                if (this.SeasonedSubordinateLiens != null)
                    hashCode = hashCode * 59 + this.SeasonedSubordinateLiens.GetHashCode();
                if (this.SecondMortgageSource != null)
                    hashCode = hashCode * 59 + this.SecondMortgageSource.GetHashCode();
                if (this.SixPercentOfLineA1 != null)
                    hashCode = hashCode * 59 + this.SixPercentOfLineA1.GetHashCode();
                if (this.MaximumSellerContribution4Percent != null)
                    hashCode = hashCode * 59 + this.MaximumSellerContribution4Percent.GetHashCode();
                if (this.StabilityOfEffectiveIncomeType != null)
                    hashCode = hashCode * 59 + this.StabilityOfEffectiveIncomeType.GetHashCode();
                if (this.StatutoryInvestment != null)
                    hashCode = hashCode * 59 + this.StatutoryInvestment.GetHashCode();
                if (this.ToBePaidAmount != null)
                    hashCode = hashCode * 59 + this.ToBePaidAmount.GetHashCode();
                if (this.TotalCashToClose != null)
                    hashCode = hashCode * 59 + this.TotalCashToClose.GetHashCode();
                if (this.TotalRequirements != null)
                    hashCode = hashCode * 59 + this.TotalRequirements.GetHashCode();
                if (this.TotalSellerContribution != null)
                    hashCode = hashCode * 59 + this.TotalSellerContribution.GetHashCode();
                if (this.UnadjustedAcquisition != null)
                    hashCode = hashCode * 59 + this.UnadjustedAcquisition.GetHashCode();
                if (this.Use85PercentRuleIndicator != null)
                    hashCode = hashCode * 59 + this.Use85PercentRuleIndicator.GetHashCode();
                if (this.RepairsImprovementAmount != null)
                    hashCode = hashCode * 59 + this.RepairsImprovementAmount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}