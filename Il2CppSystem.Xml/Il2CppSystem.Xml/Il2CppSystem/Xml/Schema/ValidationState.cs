using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000192 RID: 402
	public sealed class ValidationState : Object
	{
		// Token: 0x06002216 RID: 8726 RVA: 0x000A3AD0 File Offset: 0x000A1CD0
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationState()
		{
			Il2CppClassPointerStore<ValidationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationState>.NativeClassPtr);
			ValidationState.NativeFieldInfoPtr_IsNill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsNill");
			ValidationState.NativeFieldInfoPtr_IsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "IsDefault");
			ValidationState.NativeFieldInfoPtr_NeedValidateChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "NeedValidateChildren");
			ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CheckRequiredAttribute");
			ValidationState.NativeFieldInfoPtr_ValidationSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ValidationSkipped");
			ValidationState.NativeFieldInfoPtr_ProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ProcessContents");
			ValidationState.NativeFieldInfoPtr_Validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Validity");
			ValidationState.NativeFieldInfoPtr_ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDecl");
			ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "ElementDeclBeforeXsi");
			ValidationState.NativeFieldInfoPtr_LocalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "LocalName");
			ValidationState.NativeFieldInfoPtr_Namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Namespace");
			ValidationState.NativeFieldInfoPtr_Constr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "Constr");
			ValidationState.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurrentState");
			ValidationState.NativeFieldInfoPtr_HasMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "HasMatched");
			ValidationState.NativeFieldInfoPtr_CurPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "CurPos");
			ValidationState.NativeFieldInfoPtr_AllElementsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "AllElementsSet");
			ValidationState.NativeFieldInfoPtr_RunningPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "RunningPositions");
			ValidationState.NativeFieldInfoPtr_TooComplex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, "TooComplex");
			ValidationState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationState>.NativeClassPtr, 100668260);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000A3C7C File Offset: 0x000A1E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 408054, RefRangeEnd = 408057, XrefRangeStart = 408049, XrefRangeEnd = 408054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public ValidationState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x000A3CB8 File Offset: 0x000A1EB8
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x0000E6D1 File Offset: 0x0000C8D1
		public unsafe bool IsNill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsNill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsNill)) = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x000A3CE0 File Offset: 0x000A1EE0
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		public unsafe bool IsDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_IsDefault)) = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x000A3D08 File Offset: 0x000A1F08
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x0000E707 File Offset: 0x0000C907
		public unsafe bool NeedValidateChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_NeedValidateChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_NeedValidateChildren)) = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x000A3D30 File Offset: 0x000A1F30
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x0000E722 File Offset: 0x0000C922
		public unsafe bool CheckRequiredAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CheckRequiredAttribute)) = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x000A3D58 File Offset: 0x000A1F58
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x0000E73D File Offset: 0x0000C93D
		public unsafe bool ValidationSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ValidationSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ValidationSkipped)) = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x000A3D80 File Offset: 0x000A1F80
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x0000E758 File Offset: 0x0000C958
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ProcessContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ProcessContents)) = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x000A3DA8 File Offset: 0x000A1FA8
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x0000E773 File Offset: 0x0000C973
		public unsafe XmlSchemaValidity Validity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Validity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Validity)) = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x0000E78E File Offset: 0x0000C98E
		public unsafe SchemaElementDecl ElementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x000A3E00 File Offset: 0x000A2000
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x0000E7AD File Offset: 0x0000C9AD
		public unsafe SchemaElementDecl ElementDeclBeforeXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_ElementDeclBeforeXsi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x000A3E30 File Offset: 0x000A2030
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		public unsafe string LocalName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_LocalName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_LocalName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000A3E58 File Offset: 0x000A2058
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x0000E7EB File Offset: 0x0000C9EB
		public unsafe string Namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x000A3E80 File Offset: 0x000A2080
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x0000E80A File Offset: 0x0000CA0A
		public unsafe Il2CppReferenceArray<ConstraintStruct> Constr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Constr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstraintStruct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_Constr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000A3EB0 File Offset: 0x000A20B0
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x0000E829 File Offset: 0x0000CA29
		public unsafe StateUnion CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x000A3ED8 File Offset: 0x000A20D8
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x0000E844 File Offset: 0x0000CA44
		public unsafe bool HasMatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_HasMatched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_HasMatched)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x000A3F00 File Offset: 0x000A2100
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x0000E85F File Offset: 0x0000CA5F
		public unsafe Il2CppReferenceArray<BitSet> CurPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_CurPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000A3F30 File Offset: 0x000A2130
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x0000E87E File Offset: 0x0000CA7E
		public unsafe BitSet AllElementsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_AllElementsSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_AllElementsSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000A3F60 File Offset: 0x000A2160
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x0000E89D File Offset: 0x0000CA9D
		public unsafe List<RangePositionInfo> RunningPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_RunningPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RangePositionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_RunningPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x000A3F90 File Offset: 0x000A2190
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x0000E8BC File Offset: 0x0000CABC
		public unsafe bool TooComplex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_TooComplex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationState.NativeFieldInfoPtr_TooComplex)) = value;
			}
		}

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeFieldInfoPtr_IsNill;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeFieldInfoPtr_IsDefault;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_NeedValidateChildren;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_CheckRequiredAttribute;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_ValidationSkipped;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_ProcessContents;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeFieldInfoPtr_Validity;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_ElementDecl;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_ElementDeclBeforeXsi;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_LocalName;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_Namespace;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_Constr;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_HasMatched;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_CurPos;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr_AllElementsSet;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr_RunningPositions;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeFieldInfoPtr_TooComplex;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
