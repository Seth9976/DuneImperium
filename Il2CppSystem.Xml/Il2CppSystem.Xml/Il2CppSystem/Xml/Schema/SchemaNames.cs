using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018A RID: 394
	public sealed class SchemaNames : Object
	{
		// Token: 0x06002066 RID: 8294 RVA: 0x0009E900 File Offset: 0x0009CB00
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNames()
		{
			Il2CppClassPointerStore<SchemaNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr);
			SchemaNames.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "nameTable");
			SchemaNames.NativeFieldInfoPtr_NsDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataType");
			SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataTypeAlias");
			SchemaNames.NativeFieldInfoPtr_NsDataTypeOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsDataTypeOld");
			SchemaNames.NativeFieldInfoPtr_NsXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXml");
			SchemaNames.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXmlNs");
			SchemaNames.NativeFieldInfoPtr_NsXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXdr");
			SchemaNames.NativeFieldInfoPtr_NsXdrAlias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXdrAlias");
			SchemaNames.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXs");
			SchemaNames.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "NsXsi");
			SchemaNames.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiType");
			SchemaNames.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiNil");
			SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XsdSchema");
			SchemaNames.NativeFieldInfoPtr_XdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "XdrSchema");
			SchemaNames.NativeFieldInfoPtr_QnPCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnPCData");
			SchemaNames.NativeFieldInfoPtr_QnXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXml");
			SchemaNames.NativeFieldInfoPtr_QnXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXmlNs");
			SchemaNames.NativeFieldInfoPtr_QnDtDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtDt");
			SchemaNames.NativeFieldInfoPtr_QnXmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXmlLang");
			SchemaNames.NativeFieldInfoPtr_QnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnName");
			SchemaNames.NativeFieldInfoPtr_QnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnType");
			SchemaNames.NativeFieldInfoPtr_QnMaxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMaxOccurs");
			SchemaNames.NativeFieldInfoPtr_QnMinOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMinOccurs");
			SchemaNames.NativeFieldInfoPtr_QnInfinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnInfinite");
			SchemaNames.NativeFieldInfoPtr_QnModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnModel");
			SchemaNames.NativeFieldInfoPtr_QnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOpen");
			SchemaNames.NativeFieldInfoPtr_QnClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnClosed");
			SchemaNames.NativeFieldInfoPtr_QnContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnContent");
			SchemaNames.NativeFieldInfoPtr_QnMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMixed");
			SchemaNames.NativeFieldInfoPtr_QnEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEmpty");
			SchemaNames.NativeFieldInfoPtr_QnEltOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEltOnly");
			SchemaNames.NativeFieldInfoPtr_QnTextOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnTextOnly");
			SchemaNames.NativeFieldInfoPtr_QnOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOrder");
			SchemaNames.NativeFieldInfoPtr_QnSeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSeq");
			SchemaNames.NativeFieldInfoPtr_QnOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnOne");
			SchemaNames.NativeFieldInfoPtr_QnMany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMany");
			SchemaNames.NativeFieldInfoPtr_QnRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRequired");
			SchemaNames.NativeFieldInfoPtr_QnYes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnYes");
			SchemaNames.NativeFieldInfoPtr_QnNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNo");
			SchemaNames.NativeFieldInfoPtr_QnString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnString");
			SchemaNames.NativeFieldInfoPtr_QnID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnID");
			SchemaNames.NativeFieldInfoPtr_QnIDRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnIDRef");
			SchemaNames.NativeFieldInfoPtr_QnIDRefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnIDRefs");
			SchemaNames.NativeFieldInfoPtr_QnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEntity");
			SchemaNames.NativeFieldInfoPtr_QnEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEntities");
			SchemaNames.NativeFieldInfoPtr_QnNmToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNmToken");
			SchemaNames.NativeFieldInfoPtr_QnNmTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNmTokens");
			SchemaNames.NativeFieldInfoPtr_QnEnumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnEnumeration");
			SchemaNames.NativeFieldInfoPtr_QnDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDefault");
			SchemaNames.NativeFieldInfoPtr_QnXdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrSchema");
			SchemaNames.NativeFieldInfoPtr_QnXdrElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrElementType");
			SchemaNames.NativeFieldInfoPtr_QnXdrElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrElement");
			SchemaNames.NativeFieldInfoPtr_QnXdrGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrGroup");
			SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAttributeType");
			SchemaNames.NativeFieldInfoPtr_QnXdrAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXdrDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrDataType");
			SchemaNames.NativeFieldInfoPtr_QnXdrDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrDescription");
			SchemaNames.NativeFieldInfoPtr_QnXdrExtends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrExtends");
			SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXdrAliasSchema");
			SchemaNames.NativeFieldInfoPtr_QnDtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtType");
			SchemaNames.NativeFieldInfoPtr_QnDtValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtValues");
			SchemaNames.NativeFieldInfoPtr_QnDtMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMaxLength");
			SchemaNames.NativeFieldInfoPtr_QnDtMinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMinLength");
			SchemaNames.NativeFieldInfoPtr_QnDtMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMax");
			SchemaNames.NativeFieldInfoPtr_QnDtMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMin");
			SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMinExclusive");
			SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDtMaxExclusive");
			SchemaNames.NativeFieldInfoPtr_QnTargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnTargetNamespace");
			SchemaNames.NativeFieldInfoPtr_QnVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnVersion");
			SchemaNames.NativeFieldInfoPtr_QnFinalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFinalDefault");
			SchemaNames.NativeFieldInfoPtr_QnBlockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBlockDefault");
			SchemaNames.NativeFieldInfoPtr_QnFixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFixed");
			SchemaNames.NativeFieldInfoPtr_QnAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnAbstract");
			SchemaNames.NativeFieldInfoPtr_QnBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBlock");
			SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSubstitutionGroup");
			SchemaNames.NativeFieldInfoPtr_QnFinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnFinal");
			SchemaNames.NativeFieldInfoPtr_QnNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNillable");
			SchemaNames.NativeFieldInfoPtr_QnRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRef");
			SchemaNames.NativeFieldInfoPtr_QnBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnBase");
			SchemaNames.NativeFieldInfoPtr_QnDerivedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnDerivedBy");
			SchemaNames.NativeFieldInfoPtr_QnNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnNamespace");
			SchemaNames.NativeFieldInfoPtr_QnProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnProcessContents");
			SchemaNames.NativeFieldInfoPtr_QnRefer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnRefer");
			SchemaNames.NativeFieldInfoPtr_QnPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnPublic");
			SchemaNames.NativeFieldInfoPtr_QnSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSystem");
			SchemaNames.NativeFieldInfoPtr_QnSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSchemaLocation");
			SchemaNames.NativeFieldInfoPtr_QnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnValue");
			SchemaNames.NativeFieldInfoPtr_QnUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnUse");
			SchemaNames.NativeFieldInfoPtr_QnForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnForm");
			SchemaNames.NativeFieldInfoPtr_QnElementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnElementFormDefault");
			SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnAttributeFormDefault");
			SchemaNames.NativeFieldInfoPtr_QnItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnItemType");
			SchemaNames.NativeFieldInfoPtr_QnMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnMemberTypes");
			SchemaNames.NativeFieldInfoPtr_QnXPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXPath");
			SchemaNames.NativeFieldInfoPtr_QnXsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSchema");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnnotation");
			SchemaNames.NativeFieldInfoPtr_QnXsdInclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdInclude");
			SchemaNames.NativeFieldInfoPtr_QnXsdImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdImport");
			SchemaNames.NativeFieldInfoPtr_QnXsdElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdElement");
			SchemaNames.NativeFieldInfoPtr_QnXsdAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAttributeGroup");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnyAttribute");
			SchemaNames.NativeFieldInfoPtr_QnXsdGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdGroup");
			SchemaNames.NativeFieldInfoPtr_QnXsdAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAll");
			SchemaNames.NativeFieldInfoPtr_QnXsdChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdChoice");
			SchemaNames.NativeFieldInfoPtr_QnXsdSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSequence");
			SchemaNames.NativeFieldInfoPtr_QnXsdAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAny");
			SchemaNames.NativeFieldInfoPtr_QnXsdNotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdNotation");
			SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSimpleType");
			SchemaNames.NativeFieldInfoPtr_QnXsdComplexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdComplexType");
			SchemaNames.NativeFieldInfoPtr_QnXsdUnique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdUnique");
			SchemaNames.NativeFieldInfoPtr_QnXsdKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdKey");
			SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdKeyRef");
			SchemaNames.NativeFieldInfoPtr_QnXsdSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSelector");
			SchemaNames.NativeFieldInfoPtr_QnXsdField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdField");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinExclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinInclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxInclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxExclusive");
			SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdTotalDigits");
			SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdFractionDigits");
			SchemaNames.NativeFieldInfoPtr_QnXsdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdMinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMinLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdMaxLength");
			SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdEnumeration");
			SchemaNames.NativeFieldInfoPtr_QnXsdPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdPattern");
			SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdDocumentation");
			SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAppinfo");
			SchemaNames.NativeFieldInfoPtr_QnSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnSource");
			SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdComplexContent");
			SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdSimpleContent");
			SchemaNames.NativeFieldInfoPtr_QnXsdRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdRestriction");
			SchemaNames.NativeFieldInfoPtr_QnXsdExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdExtension");
			SchemaNames.NativeFieldInfoPtr_QnXsdUnion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdUnion");
			SchemaNames.NativeFieldInfoPtr_QnXsdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdList");
			SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdWhiteSpace");
			SchemaNames.NativeFieldInfoPtr_QnXsdRedefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdRedefine");
			SchemaNames.NativeFieldInfoPtr_QnXsdAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "QnXsdAnyType");
			SchemaNames.NativeFieldInfoPtr_TokenToQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, "TokenToQName");
			SchemaNames.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100668165);
			SchemaNames.NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100668166);
			SchemaNames.NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100668167);
			SchemaNames.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100668168);
			SchemaNames.NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr, 100668169);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0009F498 File Offset: 0x0009D698
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 404788, RefRangeEnd = 404793, XrefRangeStart = 404006, XrefRangeEnd = 404788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNames(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNames>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0009F4E4 File Offset: 0x0009D6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405291, RefRangeEnd = 405292, XrefRangeStart = 404793, XrefRangeEnd = 405291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTokenToQNameTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0009F518 File Offset: 0x0009D718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405294, RefRangeEnd = 405296, XrefRangeStart = 405292, XrefRangeEnd = 405294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType SchemaTypeFromRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0009F578 File Offset: 0x0009D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405296, XrefRangeEnd = 405297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405298, RefRangeEnd = 405299, XrefRangeStart = 405297, XrefRangeEnd = 405298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXDRRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNames.NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0000D2FD File Offset: 0x0000B4FD
		public SchemaNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0009F638 File Offset: 0x0009D838
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x0000D306 File Offset: 0x0000B506
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0009F668 File Offset: 0x0009D868
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x0000D325 File Offset: 0x0000B525
		public unsafe string NsDataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0009F690 File Offset: 0x0009D890
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x0000D344 File Offset: 0x0000B544
		public unsafe string NsDataTypeAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0009F6B8 File Offset: 0x0009D8B8
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x0000D363 File Offset: 0x0000B563
		public unsafe string NsDataTypeOld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeOld);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsDataTypeOld), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0009F6E0 File Offset: 0x0009D8E0
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0000D382 File Offset: 0x0000B582
		public unsafe string NsXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0009F708 File Offset: 0x0009D908
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0000D3A1 File Offset: 0x0000B5A1
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0009F730 File Offset: 0x0009D930
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		public unsafe string NsXdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0009F758 File Offset: 0x0009D958
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x0000D3DF File Offset: 0x0000B5DF
		public unsafe string NsXdrAlias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdrAlias);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXdrAlias), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0009F780 File Offset: 0x0009D980
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0000D3FE File Offset: 0x0000B5FE
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x0000D41D File Offset: 0x0000B61D
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0009F7F8 File Offset: 0x0009D9F8
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x0000D45B File Offset: 0x0000B65B
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0009F820 File Offset: 0x0009DA20
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0000D47A File Offset: 0x0000B67A
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0009F848 File Offset: 0x0009DA48
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0000D499 File Offset: 0x0000B699
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0009F870 File Offset: 0x0009DA70
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0009F898 File Offset: 0x0009DA98
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000D4D7 File Offset: 0x0000B6D7
		public unsafe string XdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XdrSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_XdrSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0009F8C0 File Offset: 0x0009DAC0
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000D4F6 File Offset: 0x0000B6F6
		public unsafe XmlQualifiedName QnPCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0009F8F0 File Offset: 0x0009DAF0
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000D515 File Offset: 0x0000B715
		public unsafe XmlQualifiedName QnXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXml);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXml), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0009F920 File Offset: 0x0009DB20
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000D534 File Offset: 0x0000B734
		public unsafe XmlQualifiedName QnXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlNs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlNs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0009F950 File Offset: 0x0009DB50
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000D553 File Offset: 0x0000B753
		public unsafe XmlQualifiedName QnDtDt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtDt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtDt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0009F980 File Offset: 0x0009DB80
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000D572 File Offset: 0x0000B772
		public unsafe XmlQualifiedName QnXmlLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlLang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXmlLang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0009F9B0 File Offset: 0x0009DBB0
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0000D591 File Offset: 0x0000B791
		public unsafe XmlQualifiedName QnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0009F9E0 File Offset: 0x0009DBE0
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		public unsafe XmlQualifiedName QnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0009FA10 File Offset: 0x0009DC10
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0000D5CF File Offset: 0x0000B7CF
		public unsafe XmlQualifiedName QnMaxOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMaxOccurs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMaxOccurs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0009FA40 File Offset: 0x0009DC40
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x0000D5EE File Offset: 0x0000B7EE
		public unsafe XmlQualifiedName QnMinOccurs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMinOccurs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMinOccurs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0009FA70 File Offset: 0x0009DC70
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0000D60D File Offset: 0x0000B80D
		public unsafe XmlQualifiedName QnInfinite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnInfinite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnInfinite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0000D62C File Offset: 0x0000B82C
		public unsafe XmlQualifiedName QnModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0009FAD0 File Offset: 0x0009DCD0
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000D64B File Offset: 0x0000B84B
		public unsafe XmlQualifiedName QnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0009FB00 File Offset: 0x0009DD00
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000D66A File Offset: 0x0000B86A
		public unsafe XmlQualifiedName QnClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0009FB30 File Offset: 0x0009DD30
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000D689 File Offset: 0x0000B889
		public unsafe XmlQualifiedName QnContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0009FB60 File Offset: 0x0009DD60
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public unsafe XmlQualifiedName QnMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0009FB90 File Offset: 0x0009DD90
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x0000D6C7 File Offset: 0x0000B8C7
		public unsafe XmlQualifiedName QnEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0009FBC0 File Offset: 0x0009DDC0
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x0000D6E6 File Offset: 0x0000B8E6
		public unsafe XmlQualifiedName QnEltOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEltOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEltOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0009FBF0 File Offset: 0x0009DDF0
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0000D705 File Offset: 0x0000B905
		public unsafe XmlQualifiedName QnTextOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTextOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTextOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0009FC20 File Offset: 0x0009DE20
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0000D724 File Offset: 0x0000B924
		public unsafe XmlQualifiedName QnOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0009FC50 File Offset: 0x0009DE50
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0000D743 File Offset: 0x0000B943
		public unsafe XmlQualifiedName QnSeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSeq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSeq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0009FC80 File Offset: 0x0009DE80
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0000D762 File Offset: 0x0000B962
		public unsafe XmlQualifiedName QnOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0009FCB0 File Offset: 0x0009DEB0
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0000D781 File Offset: 0x0000B981
		public unsafe XmlQualifiedName QnMany
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMany);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMany), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0009FCE0 File Offset: 0x0009DEE0
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		public unsafe XmlQualifiedName QnRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRequired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRequired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0009FD10 File Offset: 0x0009DF10
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000D7BF File Offset: 0x0000B9BF
		public unsafe XmlQualifiedName QnYes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnYes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnYes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0009FD40 File Offset: 0x0009DF40
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0000D7DE File Offset: 0x0000B9DE
		public unsafe XmlQualifiedName QnNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0009FD70 File Offset: 0x0009DF70
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0000D7FD File Offset: 0x0000B9FD
		public unsafe XmlQualifiedName QnString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0009FDA0 File Offset: 0x0009DFA0
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0000D81C File Offset: 0x0000BA1C
		public unsafe XmlQualifiedName QnID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0009FDD0 File Offset: 0x0009DFD0
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0000D83B File Offset: 0x0000BA3B
		public unsafe XmlQualifiedName QnIDRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0009FE00 File Offset: 0x0009E000
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0000D85A File Offset: 0x0000BA5A
		public unsafe XmlQualifiedName QnIDRefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnIDRefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0009FE30 File Offset: 0x0009E030
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0000D879 File Offset: 0x0000BA79
		public unsafe XmlQualifiedName QnEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0009FE60 File Offset: 0x0009E060
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0000D898 File Offset: 0x0000BA98
		public unsafe XmlQualifiedName QnEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0009FE90 File Offset: 0x0009E090
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x0000D8B7 File Offset: 0x0000BAB7
		public unsafe XmlQualifiedName QnNmToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0009FEC0 File Offset: 0x0009E0C0
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000D8D6 File Offset: 0x0000BAD6
		public unsafe XmlQualifiedName QnNmTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNmTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0000D8F5 File Offset: 0x0000BAF5
		public unsafe XmlQualifiedName QnEnumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEnumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnEnumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0009FF20 File Offset: 0x0009E120
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x0000D914 File Offset: 0x0000BB14
		public unsafe XmlQualifiedName QnDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0009FF50 File Offset: 0x0009E150
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x0000D933 File Offset: 0x0000BB33
		public unsafe XmlQualifiedName QnXdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0009FF80 File Offset: 0x0009E180
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x0000D952 File Offset: 0x0000BB52
		public unsafe XmlQualifiedName QnXdrElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0000D971 File Offset: 0x0000BB71
		public unsafe XmlQualifiedName QnXdrElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0009FFE0 File Offset: 0x0009E1E0
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x0000D990 File Offset: 0x0000BB90
		public unsafe XmlQualifiedName QnXdrGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x000A0010 File Offset: 0x0009E210
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x0000D9AF File Offset: 0x0000BBAF
		public unsafe XmlQualifiedName QnXdrAttributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000A0040 File Offset: 0x0009E240
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x0000D9CE File Offset: 0x0000BBCE
		public unsafe XmlQualifiedName QnXdrAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000A0070 File Offset: 0x0009E270
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x0000D9ED File Offset: 0x0000BBED
		public unsafe XmlQualifiedName QnXdrDataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000A00A0 File Offset: 0x0009E2A0
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		public unsafe XmlQualifiedName QnXdrDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000A00D0 File Offset: 0x0009E2D0
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0000DA2B File Offset: 0x0000BC2B
		public unsafe XmlQualifiedName QnXdrExtends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrExtends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrExtends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000A0100 File Offset: 0x0009E300
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x0000DA4A File Offset: 0x0000BC4A
		public unsafe XmlQualifiedName QnXdrAliasSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXdrAliasSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x000A0130 File Offset: 0x0009E330
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000DA69 File Offset: 0x0000BC69
		public unsafe XmlQualifiedName QnDtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x000A0160 File Offset: 0x0009E360
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x0000DA88 File Offset: 0x0000BC88
		public unsafe XmlQualifiedName QnDtValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x000A0190 File Offset: 0x0009E390
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000DAA7 File Offset: 0x0000BCA7
		public unsafe XmlQualifiedName QnDtMaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x000A01C0 File Offset: 0x0009E3C0
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000DAC6 File Offset: 0x0000BCC6
		public unsafe XmlQualifiedName QnDtMinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x000A01F0 File Offset: 0x0009E3F0
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0000DAE5 File Offset: 0x0000BCE5
		public unsafe XmlQualifiedName QnDtMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x000A0220 File Offset: 0x0009E420
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0000DB04 File Offset: 0x0000BD04
		public unsafe XmlQualifiedName QnDtMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x000A0250 File Offset: 0x0009E450
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0000DB23 File Offset: 0x0000BD23
		public unsafe XmlQualifiedName QnDtMinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000A0280 File Offset: 0x0009E480
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x0000DB42 File Offset: 0x0000BD42
		public unsafe XmlQualifiedName QnDtMaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDtMaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000A02B0 File Offset: 0x0009E4B0
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x0000DB61 File Offset: 0x0000BD61
		public unsafe XmlQualifiedName QnTargetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTargetNamespace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnTargetNamespace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000A02E0 File Offset: 0x0009E4E0
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x0000DB80 File Offset: 0x0000BD80
		public unsafe XmlQualifiedName QnVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x000A0310 File Offset: 0x0009E510
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x0000DB9F File Offset: 0x0000BD9F
		public unsafe XmlQualifiedName QnFinalDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinalDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinalDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x000A0340 File Offset: 0x0009E540
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x0000DBBE File Offset: 0x0000BDBE
		public unsafe XmlQualifiedName QnBlockDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlockDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlockDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x000A0370 File Offset: 0x0009E570
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x0000DBDD File Offset: 0x0000BDDD
		public unsafe XmlQualifiedName QnFixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x000A03A0 File Offset: 0x0009E5A0
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x0000DBFC File Offset: 0x0000BDFC
		public unsafe XmlQualifiedName QnAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAbstract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAbstract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x000A03D0 File Offset: 0x0009E5D0
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x0000DC1B File Offset: 0x0000BE1B
		public unsafe XmlQualifiedName QnBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x000A0400 File Offset: 0x0009E600
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x0000DC3A File Offset: 0x0000BE3A
		public unsafe XmlQualifiedName QnSubstitutionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSubstitutionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x000A0430 File Offset: 0x0009E630
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x0000DC59 File Offset: 0x0000BE59
		public unsafe XmlQualifiedName QnFinal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnFinal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x000A0460 File Offset: 0x0009E660
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x0000DC78 File Offset: 0x0000BE78
		public unsafe XmlQualifiedName QnNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000A0490 File Offset: 0x0009E690
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x0000DC97 File Offset: 0x0000BE97
		public unsafe XmlQualifiedName QnRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x000A04C0 File Offset: 0x0009E6C0
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x0000DCB6 File Offset: 0x0000BEB6
		public unsafe XmlQualifiedName QnBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x000A04F0 File Offset: 0x0009E6F0
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x0000DCD5 File Offset: 0x0000BED5
		public unsafe XmlQualifiedName QnDerivedBy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDerivedBy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnDerivedBy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000A0520 File Offset: 0x0009E720
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		public unsafe XmlQualifiedName QnNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNamespace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnNamespace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000A0550 File Offset: 0x0009E750
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x0000DD13 File Offset: 0x0000BF13
		public unsafe XmlQualifiedName QnProcessContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnProcessContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnProcessContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x000A0580 File Offset: 0x0009E780
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x0000DD32 File Offset: 0x0000BF32
		public unsafe XmlQualifiedName QnRefer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRefer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnRefer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A05B0 File Offset: 0x0009E7B0
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x0000DD51 File Offset: 0x0000BF51
		public unsafe XmlQualifiedName QnPublic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPublic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnPublic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000A05E0 File Offset: 0x0009E7E0
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public unsafe XmlQualifiedName QnSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000A0610 File Offset: 0x0009E810
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x0000DD8F File Offset: 0x0000BF8F
		public unsafe XmlQualifiedName QnSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSchemaLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSchemaLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x000A0640 File Offset: 0x0009E840
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x0000DDAE File Offset: 0x0000BFAE
		public unsafe XmlQualifiedName QnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000A0670 File Offset: 0x0009E870
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000DDCD File Offset: 0x0000BFCD
		public unsafe XmlQualifiedName QnUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000A06A0 File Offset: 0x0009E8A0
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public unsafe XmlQualifiedName QnForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnForm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnForm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000A06D0 File Offset: 0x0009E8D0
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000DE0B File Offset: 0x0000C00B
		public unsafe XmlQualifiedName QnElementFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnElementFormDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnElementFormDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000A0700 File Offset: 0x0009E900
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000DE2A File Offset: 0x0000C02A
		public unsafe XmlQualifiedName QnAttributeFormDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnAttributeFormDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000A0730 File Offset: 0x0009E930
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x0000DE49 File Offset: 0x0000C049
		public unsafe XmlQualifiedName QnItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000A0760 File Offset: 0x0009E960
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x0000DE68 File Offset: 0x0000C068
		public unsafe XmlQualifiedName QnMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000A0790 File Offset: 0x0009E990
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000DE87 File Offset: 0x0000C087
		public unsafe XmlQualifiedName QnXPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x0000DEA6 File Offset: 0x0000C0A6
		public unsafe XmlQualifiedName QnXsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000A07F0 File Offset: 0x0009E9F0
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000DEC5 File Offset: 0x0000C0C5
		public unsafe XmlQualifiedName QnXsdAnnotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnnotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000A0820 File Offset: 0x0009EA20
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		public unsafe XmlQualifiedName QnXsdInclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdInclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdInclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000A0850 File Offset: 0x0009EA50
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000DF03 File Offset: 0x0000C103
		public unsafe XmlQualifiedName QnXsdImport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdImport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdImport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000A0880 File Offset: 0x0009EA80
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000DF22 File Offset: 0x0000C122
		public unsafe XmlQualifiedName QnXsdElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000A08B0 File Offset: 0x0009EAB0
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000DF41 File Offset: 0x0000C141
		public unsafe XmlQualifiedName QnXsdAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000A08E0 File Offset: 0x0009EAE0
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000DF60 File Offset: 0x0000C160
		public unsafe XmlQualifiedName QnXsdAttributeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAttributeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000A0910 File Offset: 0x0009EB10
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000DF7F File Offset: 0x0000C17F
		public unsafe XmlQualifiedName QnXsdAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000A0940 File Offset: 0x0009EB40
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0000DF9E File Offset: 0x0000C19E
		public unsafe XmlQualifiedName QnXsdGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000A0970 File Offset: 0x0009EB70
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000DFBD File Offset: 0x0000C1BD
		public unsafe XmlQualifiedName QnXsdAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000A09A0 File Offset: 0x0009EBA0
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		public unsafe XmlQualifiedName QnXsdChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000A09D0 File Offset: 0x0009EBD0
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0000DFFB File Offset: 0x0000C1FB
		public unsafe XmlQualifiedName QnXsdSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000A0A00 File Offset: 0x0009EC00
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000E01A File Offset: 0x0000C21A
		public unsafe XmlQualifiedName QnXsdAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAny);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000A0A30 File Offset: 0x0009EC30
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x0000E039 File Offset: 0x0000C239
		public unsafe XmlQualifiedName QnXsdNotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdNotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdNotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000A0A60 File Offset: 0x0009EC60
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0000E058 File Offset: 0x0000C258
		public unsafe XmlQualifiedName QnXsdSimpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000A0A90 File Offset: 0x0009EC90
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x0000E077 File Offset: 0x0000C277
		public unsafe XmlQualifiedName QnXsdComplexType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000A0AC0 File Offset: 0x0009ECC0
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0000E096 File Offset: 0x0000C296
		public unsafe XmlQualifiedName QnXsdUnique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnique);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnique), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000A0AF0 File Offset: 0x0009ECF0
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
		public unsafe XmlQualifiedName QnXsdKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000A0B20 File Offset: 0x0009ED20
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		public unsafe XmlQualifiedName QnXsdKeyRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdKeyRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000A0B50 File Offset: 0x0009ED50
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		public unsafe XmlQualifiedName QnXsdSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000A0B80 File Offset: 0x0009ED80
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x0000E112 File Offset: 0x0000C312
		public unsafe XmlQualifiedName QnXsdField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000A0BB0 File Offset: 0x0009EDB0
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x0000E131 File Offset: 0x0000C331
		public unsafe XmlQualifiedName QnXsdMinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x0000E150 File Offset: 0x0000C350
		public unsafe XmlQualifiedName QnXsdMinInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000A0C10 File Offset: 0x0009EE10
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x0000E16F File Offset: 0x0000C36F
		public unsafe XmlQualifiedName QnXsdMaxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000A0C40 File Offset: 0x0009EE40
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x0000E18E File Offset: 0x0000C38E
		public unsafe XmlQualifiedName QnXsdMaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000A0C70 File Offset: 0x0009EE70
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x0000E1AD File Offset: 0x0000C3AD
		public unsafe XmlQualifiedName QnXsdTotalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdTotalDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000A0CA0 File Offset: 0x0009EEA0
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		public unsafe XmlQualifiedName QnXsdFractionDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdFractionDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000A0CD0 File Offset: 0x0009EED0
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x0000E1EB File Offset: 0x0000C3EB
		public unsafe XmlQualifiedName QnXsdLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000A0D00 File Offset: 0x0009EF00
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x0000E20A File Offset: 0x0000C40A
		public unsafe XmlQualifiedName QnXsdMinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMinLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000A0D30 File Offset: 0x0009EF30
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x0000E229 File Offset: 0x0000C429
		public unsafe XmlQualifiedName QnXsdMaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdMaxLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000A0D60 File Offset: 0x0009EF60
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x0000E248 File Offset: 0x0000C448
		public unsafe XmlQualifiedName QnXsdEnumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdEnumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000A0D90 File Offset: 0x0009EF90
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x0000E267 File Offset: 0x0000C467
		public unsafe XmlQualifiedName QnXsdPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdPattern);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdPattern), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000A0DC0 File Offset: 0x0009EFC0
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x0000E286 File Offset: 0x0000C486
		public unsafe XmlQualifiedName QnXsdDocumentation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdDocumentation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000A0DF0 File Offset: 0x0009EFF0
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x0000E2A5 File Offset: 0x0000C4A5
		public unsafe XmlQualifiedName QnXsdAppinfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAppinfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000A0E20 File Offset: 0x0009F020
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		public unsafe XmlQualifiedName QnSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000A0E50 File Offset: 0x0009F050
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		public unsafe XmlQualifiedName QnXsdComplexContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdComplexContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000A0E80 File Offset: 0x0009F080
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x0000E302 File Offset: 0x0000C502
		public unsafe XmlQualifiedName QnXsdSimpleContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdSimpleContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000A0EB0 File Offset: 0x0009F0B0
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x0000E321 File Offset: 0x0000C521
		public unsafe XmlQualifiedName QnXsdRestriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRestriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000A0EE0 File Offset: 0x0009F0E0
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x0000E340 File Offset: 0x0000C540
		public unsafe XmlQualifiedName QnXsdExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000A0F10 File Offset: 0x0009F110
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x0000E35F File Offset: 0x0000C55F
		public unsafe XmlQualifiedName QnXsdUnion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdUnion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000A0F40 File Offset: 0x0009F140
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x0000E37E File Offset: 0x0000C57E
		public unsafe XmlQualifiedName QnXsdList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000A0F70 File Offset: 0x0009F170
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x0000E39D File Offset: 0x0000C59D
		public unsafe XmlQualifiedName QnXsdWhiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdWhiteSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x000A0FA0 File Offset: 0x0009F1A0
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		public unsafe XmlQualifiedName QnXsdRedefine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRedefine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdRedefine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000A0FD0 File Offset: 0x0009F1D0
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x0000E3DB File Offset: 0x0000C5DB
		public unsafe XmlQualifiedName QnXsdAnyType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_QnXsdAnyType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000A1000 File Offset: 0x0009F200
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x0000E3FA File Offset: 0x0000C5FA
		public unsafe Il2CppReferenceArray<XmlQualifiedName> TokenToQName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_TokenToQName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNames.NativeFieldInfoPtr_TokenToQName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeFieldInfoPtr_NsDataType;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_NsDataTypeAlias;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeFieldInfoPtr_NsDataTypeOld;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeFieldInfoPtr_NsXml;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeFieldInfoPtr_NsXdr;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr_NsXdrAlias;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeFieldInfoPtr_XdrSchema;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeFieldInfoPtr_QnPCData;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr_QnXml;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr_QnXmlNs;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeFieldInfoPtr_QnDtDt;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeFieldInfoPtr_QnXmlLang;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeFieldInfoPtr_QnName;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeFieldInfoPtr_QnType;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeFieldInfoPtr_QnMaxOccurs;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeFieldInfoPtr_QnMinOccurs;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeFieldInfoPtr_QnInfinite;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeFieldInfoPtr_QnModel;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeFieldInfoPtr_QnOpen;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeFieldInfoPtr_QnClosed;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeFieldInfoPtr_QnContent;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeFieldInfoPtr_QnMixed;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_QnEmpty;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_QnEltOnly;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeFieldInfoPtr_QnTextOnly;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr_QnOrder;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_QnSeq;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_QnOne;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_QnMany;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_QnRequired;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_QnYes;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_QnNo;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_QnString;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_QnID;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_QnIDRef;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeFieldInfoPtr_QnIDRefs;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeFieldInfoPtr_QnEntity;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeFieldInfoPtr_QnEntities;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeFieldInfoPtr_QnNmToken;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeFieldInfoPtr_QnNmTokens;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeFieldInfoPtr_QnEnumeration;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr_QnDefault;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrSchema;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrElementType;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrElement;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrGroup;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAttributeType;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAttribute;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrDataType;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrDescription;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrExtends;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeFieldInfoPtr_QnXdrAliasSchema;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeFieldInfoPtr_QnDtType;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr_QnDtValues;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMaxLength;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMinLength;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMax;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMin;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMinExclusive;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr_QnDtMaxExclusive;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeFieldInfoPtr_QnTargetNamespace;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeFieldInfoPtr_QnVersion;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeFieldInfoPtr_QnFinalDefault;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeFieldInfoPtr_QnBlockDefault;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeFieldInfoPtr_QnFixed;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_QnAbstract;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeFieldInfoPtr_QnBlock;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_QnSubstitutionGroup;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_QnFinal;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr_QnNillable;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr_QnRef;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr_QnBase;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeFieldInfoPtr_QnDerivedBy;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeFieldInfoPtr_QnNamespace;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeFieldInfoPtr_QnProcessContents;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeFieldInfoPtr_QnRefer;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeFieldInfoPtr_QnPublic;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeFieldInfoPtr_QnSystem;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeFieldInfoPtr_QnSchemaLocation;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr_QnValue;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr_QnUse;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr_QnForm;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr_QnElementFormDefault;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_QnAttributeFormDefault;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeFieldInfoPtr_QnItemType;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeFieldInfoPtr_QnMemberTypes;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeFieldInfoPtr_QnXPath;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSchema;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnnotation;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdInclude;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdImport;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdElement;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAttribute;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAttributeGroup;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnyAttribute;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdGroup;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAll;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdChoice;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSequence;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAny;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdNotation;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSimpleType;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdComplexType;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdUnique;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdKey;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdKeyRef;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSelector;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdField;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinExclusive;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinInclusive;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxInclusive;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxExclusive;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdTotalDigits;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdFractionDigits;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdLength;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMinLength;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdMaxLength;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdEnumeration;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdPattern;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdDocumentation;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAppinfo;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeFieldInfoPtr_QnSource;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdComplexContent;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdSimpleContent;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdRestriction;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdExtension;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdUnion;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdList;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdWhiteSpace;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdRedefine;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeFieldInfoPtr_QnXsdAnyType;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeFieldInfoPtr_TokenToQName;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_CreateTokenToQNameTable_Public_Void_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_SchemaTypeFromRoot_Public_SchemaType_String_String_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_IsXDRRoot_Public_Boolean_String_String_0;

		// Token: 0x0200025F RID: 607
		public enum Token
		{
			// Token: 0x04002675 RID: 9845
			Empty,
			// Token: 0x04002676 RID: 9846
			SchemaName,
			// Token: 0x04002677 RID: 9847
			SchemaType,
			// Token: 0x04002678 RID: 9848
			SchemaMaxOccurs,
			// Token: 0x04002679 RID: 9849
			SchemaMinOccurs,
			// Token: 0x0400267A RID: 9850
			SchemaInfinite,
			// Token: 0x0400267B RID: 9851
			SchemaModel,
			// Token: 0x0400267C RID: 9852
			SchemaOpen,
			// Token: 0x0400267D RID: 9853
			SchemaClosed,
			// Token: 0x0400267E RID: 9854
			SchemaContent,
			// Token: 0x0400267F RID: 9855
			SchemaMixed,
			// Token: 0x04002680 RID: 9856
			SchemaEmpty,
			// Token: 0x04002681 RID: 9857
			SchemaElementOnly,
			// Token: 0x04002682 RID: 9858
			SchemaTextOnly,
			// Token: 0x04002683 RID: 9859
			SchemaOrder,
			// Token: 0x04002684 RID: 9860
			SchemaSeq,
			// Token: 0x04002685 RID: 9861
			SchemaOne,
			// Token: 0x04002686 RID: 9862
			SchemaMany,
			// Token: 0x04002687 RID: 9863
			SchemaRequired,
			// Token: 0x04002688 RID: 9864
			SchemaYes,
			// Token: 0x04002689 RID: 9865
			SchemaNo,
			// Token: 0x0400268A RID: 9866
			SchemaString,
			// Token: 0x0400268B RID: 9867
			SchemaId,
			// Token: 0x0400268C RID: 9868
			SchemaIdref,
			// Token: 0x0400268D RID: 9869
			SchemaIdrefs,
			// Token: 0x0400268E RID: 9870
			SchemaEntity,
			// Token: 0x0400268F RID: 9871
			SchemaEntities,
			// Token: 0x04002690 RID: 9872
			SchemaNmtoken,
			// Token: 0x04002691 RID: 9873
			SchemaNmtokens,
			// Token: 0x04002692 RID: 9874
			SchemaEnumeration,
			// Token: 0x04002693 RID: 9875
			SchemaDefault,
			// Token: 0x04002694 RID: 9876
			XdrRoot,
			// Token: 0x04002695 RID: 9877
			XdrElementType,
			// Token: 0x04002696 RID: 9878
			XdrElement,
			// Token: 0x04002697 RID: 9879
			XdrGroup,
			// Token: 0x04002698 RID: 9880
			XdrAttributeType,
			// Token: 0x04002699 RID: 9881
			XdrAttribute,
			// Token: 0x0400269A RID: 9882
			XdrDatatype,
			// Token: 0x0400269B RID: 9883
			XdrDescription,
			// Token: 0x0400269C RID: 9884
			XdrExtends,
			// Token: 0x0400269D RID: 9885
			SchemaXdrRootAlias,
			// Token: 0x0400269E RID: 9886
			SchemaDtType,
			// Token: 0x0400269F RID: 9887
			SchemaDtValues,
			// Token: 0x040026A0 RID: 9888
			SchemaDtMaxLength,
			// Token: 0x040026A1 RID: 9889
			SchemaDtMinLength,
			// Token: 0x040026A2 RID: 9890
			SchemaDtMax,
			// Token: 0x040026A3 RID: 9891
			SchemaDtMin,
			// Token: 0x040026A4 RID: 9892
			SchemaDtMinExclusive,
			// Token: 0x040026A5 RID: 9893
			SchemaDtMaxExclusive,
			// Token: 0x040026A6 RID: 9894
			SchemaTargetNamespace,
			// Token: 0x040026A7 RID: 9895
			SchemaVersion,
			// Token: 0x040026A8 RID: 9896
			SchemaFinalDefault,
			// Token: 0x040026A9 RID: 9897
			SchemaBlockDefault,
			// Token: 0x040026AA RID: 9898
			SchemaFixed,
			// Token: 0x040026AB RID: 9899
			SchemaAbstract,
			// Token: 0x040026AC RID: 9900
			SchemaBlock,
			// Token: 0x040026AD RID: 9901
			SchemaSubstitutionGroup,
			// Token: 0x040026AE RID: 9902
			SchemaFinal,
			// Token: 0x040026AF RID: 9903
			SchemaNillable,
			// Token: 0x040026B0 RID: 9904
			SchemaRef,
			// Token: 0x040026B1 RID: 9905
			SchemaBase,
			// Token: 0x040026B2 RID: 9906
			SchemaDerivedBy,
			// Token: 0x040026B3 RID: 9907
			SchemaNamespace,
			// Token: 0x040026B4 RID: 9908
			SchemaProcessContents,
			// Token: 0x040026B5 RID: 9909
			SchemaRefer,
			// Token: 0x040026B6 RID: 9910
			SchemaPublic,
			// Token: 0x040026B7 RID: 9911
			SchemaSystem,
			// Token: 0x040026B8 RID: 9912
			SchemaSchemaLocation,
			// Token: 0x040026B9 RID: 9913
			SchemaValue,
			// Token: 0x040026BA RID: 9914
			SchemaSource,
			// Token: 0x040026BB RID: 9915
			SchemaAttributeFormDefault,
			// Token: 0x040026BC RID: 9916
			SchemaElementFormDefault,
			// Token: 0x040026BD RID: 9917
			SchemaUse,
			// Token: 0x040026BE RID: 9918
			SchemaForm,
			// Token: 0x040026BF RID: 9919
			XsdSchema,
			// Token: 0x040026C0 RID: 9920
			XsdAnnotation,
			// Token: 0x040026C1 RID: 9921
			XsdInclude,
			// Token: 0x040026C2 RID: 9922
			XsdImport,
			// Token: 0x040026C3 RID: 9923
			XsdElement,
			// Token: 0x040026C4 RID: 9924
			XsdAttribute,
			// Token: 0x040026C5 RID: 9925
			xsdAttributeGroup,
			// Token: 0x040026C6 RID: 9926
			XsdAnyAttribute,
			// Token: 0x040026C7 RID: 9927
			XsdGroup,
			// Token: 0x040026C8 RID: 9928
			XsdAll,
			// Token: 0x040026C9 RID: 9929
			XsdChoice,
			// Token: 0x040026CA RID: 9930
			XsdSequence,
			// Token: 0x040026CB RID: 9931
			XsdAny,
			// Token: 0x040026CC RID: 9932
			XsdNotation,
			// Token: 0x040026CD RID: 9933
			XsdSimpleType,
			// Token: 0x040026CE RID: 9934
			XsdComplexType,
			// Token: 0x040026CF RID: 9935
			XsdUnique,
			// Token: 0x040026D0 RID: 9936
			XsdKey,
			// Token: 0x040026D1 RID: 9937
			XsdKeyref,
			// Token: 0x040026D2 RID: 9938
			XsdSelector,
			// Token: 0x040026D3 RID: 9939
			XsdField,
			// Token: 0x040026D4 RID: 9940
			XsdMinExclusive,
			// Token: 0x040026D5 RID: 9941
			XsdMinInclusive,
			// Token: 0x040026D6 RID: 9942
			XsdMaxExclusive,
			// Token: 0x040026D7 RID: 9943
			XsdMaxInclusive,
			// Token: 0x040026D8 RID: 9944
			XsdTotalDigits,
			// Token: 0x040026D9 RID: 9945
			XsdFractionDigits,
			// Token: 0x040026DA RID: 9946
			XsdLength,
			// Token: 0x040026DB RID: 9947
			XsdMinLength,
			// Token: 0x040026DC RID: 9948
			XsdMaxLength,
			// Token: 0x040026DD RID: 9949
			XsdEnumeration,
			// Token: 0x040026DE RID: 9950
			XsdPattern,
			// Token: 0x040026DF RID: 9951
			XsdDocumentation,
			// Token: 0x040026E0 RID: 9952
			XsdAppInfo,
			// Token: 0x040026E1 RID: 9953
			XsdComplexContent,
			// Token: 0x040026E2 RID: 9954
			XsdComplexContentExtension,
			// Token: 0x040026E3 RID: 9955
			XsdComplexContentRestriction,
			// Token: 0x040026E4 RID: 9956
			XsdSimpleContent,
			// Token: 0x040026E5 RID: 9957
			XsdSimpleContentExtension,
			// Token: 0x040026E6 RID: 9958
			XsdSimpleContentRestriction,
			// Token: 0x040026E7 RID: 9959
			XsdSimpleTypeList,
			// Token: 0x040026E8 RID: 9960
			XsdSimpleTypeRestriction,
			// Token: 0x040026E9 RID: 9961
			XsdSimpleTypeUnion,
			// Token: 0x040026EA RID: 9962
			XsdWhitespace,
			// Token: 0x040026EB RID: 9963
			XsdRedefine,
			// Token: 0x040026EC RID: 9964
			SchemaItemType,
			// Token: 0x040026ED RID: 9965
			SchemaMemberTypes,
			// Token: 0x040026EE RID: 9966
			SchemaXPath,
			// Token: 0x040026EF RID: 9967
			XmlLang
		}
	}
}
