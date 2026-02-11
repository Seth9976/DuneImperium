using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000122 RID: 290
	public sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x06001944 RID: 6468 RVA: 0x00081904 File Offset: 0x0007FB04
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleContentValidator()
		{
			Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ParticleContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr);
			ParticleContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "symbols");
			ParticleContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "positions");
			ParticleContentValidator.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "stack");
			ParticleContentValidator.NativeFieldInfoPtr_contentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "contentNode");
			ParticleContentValidator.NativeFieldInfoPtr_isPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "isPartial");
			ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "minMaxNodesCount");
			ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "enableUpaCheck");
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667193);
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667194);
			ParticleContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667195);
			ParticleContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667196);
			ParticleContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667197);
			ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667198);
			ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667199);
			ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667200);
			ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667201);
			ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667202);
			ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667203);
			ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667204);
			ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667205);
			ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667206);
			ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667207);
			ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667208);
			ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667209);
			ParticleContentValidator.NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667210);
			ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667211);
			ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667212);
			ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667213);
			ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667214);
			ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667215);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667216);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667217);
			ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100667218);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00081BC8 File Offset: 0x0007FDC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 392472, RefRangeEnd = 392477, XrefRangeStart = 392468, XrefRangeEnd = 392472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00081C10 File Offset: 0x0007FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392477, XrefRangeEnd = 392481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableUpaCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00081C68 File Offset: 0x0007FE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392481, XrefRangeEnd = 392486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00081CAC File Offset: 0x0007FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392486, XrefRangeEnd = 392491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00081D1C File Offset: 0x0007FF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392491, XrefRangeEnd = 392496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00081D6C File Offset: 0x0007FF6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392526, RefRangeEnd = 392530, XrefRangeStart = 392496, XrefRangeEnd = 392526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00081DA0 File Offset: 0x0007FFA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 392531, RefRangeEnd = 392538, XrefRangeStart = 392530, XrefRangeEnd = 392531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 392544, RefRangeEnd = 392550, XrefRangeStart = 392538, XrefRangeEnd = 392544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00081E08 File Offset: 0x00080008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392550, RefRangeEnd = 392551, XrefRangeStart = 392550, XrefRangeEnd = 392550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00081E58 File Offset: 0x00080058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 392559, RefRangeEnd = 392564, XrefRangeStart = 392551, XrefRangeEnd = 392559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00081EAC File Offset: 0x000800AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392573, RefRangeEnd = 392575, XrefRangeStart = 392564, XrefRangeEnd = 392573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList namespaceList, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00081F00 File Offset: 0x00080100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392578, RefRangeEnd = 392580, XrefRangeStart = 392575, XrefRangeEnd = 392578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeafNode(SyntaxTreeNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00081F44 File Offset: 0x00080144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392589, RefRangeEnd = 392593, XrefRangeStart = 392580, XrefRangeEnd = 392589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00081F78 File Offset: 0x00080178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 392602, RefRangeEnd = 392605, XrefRangeStart = 392593, XrefRangeEnd = 392602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00081FAC File Offset: 0x000801AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 392610, RefRangeEnd = 392618, XrefRangeStart = 392605, XrefRangeEnd = 392610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00081FE0 File Offset: 0x000801E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 392623, RefRangeEnd = 392629, XrefRangeStart = 392618, XrefRangeEnd = 392623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00082014 File Offset: 0x00080214
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 392634, RefRangeEnd = 392640, XrefRangeStart = 392629, XrefRangeEnd = 392634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQMark()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00082048 File Offset: 0x00080248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392651, RefRangeEnd = 392652, XrefRangeStart = 392640, XrefRangeEnd = 392651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeafRange(Decimal min, Decimal max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00082094 File Offset: 0x00080294
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392656, RefRangeEnd = 392660, XrefRangeStart = 392652, XrefRangeEnd = 392656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Closure(InteriorNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000820D8 File Offset: 0x000802D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392715, RefRangeEnd = 392719, XrefRangeStart = 392660, XrefRangeEnd = 392715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator Finish(bool useDFA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useDFA;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00082124 File Offset: 0x00080324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392719, XrefRangeEnd = 392753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<BitSet> CalculateTotalFollowposForRangeNodes(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, out BitSet posWithRangeTerminals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			posWithRangeTerminals = ((intPtr4 == 0) ? null : new BitSet(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr5) : null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000821AC File Offset: 0x000803AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392753, XrefRangeEnd = 392763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000821F0 File Offset: 0x000803F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392763, XrefRangeEnd = 392784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, Il2CppReferenceArray<BitSet> minmaxFollowPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(posWithRangeTerminals);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minmaxFollowPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00082264 File Offset: 0x00080464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392784, XrefRangeEnd = 392787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x000822B8 File Offset: 0x000804B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392800, RefRangeEnd = 392804, XrefRangeStart = 392787, XrefRangeEnd = 392800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000822FC File Offset: 0x000804FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392854, RefRangeEnd = 392855, XrefRangeStart = 392804, XrefRangeEnd = 392854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> BuildTransitionTable(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, int endMarkerPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr3) : null;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0000AC32 File Offset: 0x00008E32
		public ParticleContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0008236C File Offset: 0x0008056C
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000AC3B File Offset: 0x00008E3B
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0008239C File Offset: 0x0008059C
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000AC5A File Offset: 0x00008E5A
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000823CC File Offset: 0x000805CC
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000AC79 File Offset: 0x00008E79
		public unsafe Stack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000823FC File Offset: 0x000805FC
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000AC98 File Offset: 0x00008E98
		public unsafe SyntaxTreeNode contentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0008242C File Offset: 0x0008062C
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0000ACB7 File Offset: 0x00008EB7
		public unsafe bool isPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial)) = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00082454 File Offset: 0x00080654
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000ACD2 File Offset: 0x00008ED2
		public unsafe int minMaxNodesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount)) = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0008247C File Offset: 0x0008067C
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000ACED File Offset: 0x00008EED
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr_contentNode;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr_isPartial;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr_minMaxNodesCount;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_Void_ValidationState_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Boolean_ValidationState_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_OpenGroup_Public_Void_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_CloseGroup_Public_Void_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_AddChoice_Public_Void_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_AddSequence_Public_Void_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_AddStar_Public_Void_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_AddPlus_Public_Void_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_AddQMark_Public_Void_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_AddLeafRange_Public_Void_Decimal_Decimal_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0;
	}
}
