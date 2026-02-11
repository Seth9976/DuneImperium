using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DF RID: 479
	public class XmlSchemaSubstitutionGroup : XmlSchemaObject
	{
		// Token: 0x06002816 RID: 10262 RVA: 0x000BA80C File Offset: 0x000B8A0C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSubstitutionGroup()
		{
			Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSubstitutionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr);
			XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, "membersList");
			XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, "examplar");
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100669092);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100669093);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100669094);
			XmlSchemaSubstitutionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr, 100669095);
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000BA8B4 File Offset: 0x000B8AB4
		public unsafe ArrayList Members
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000BA8F4 File Offset: 0x000B8AF4
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x000BA934 File Offset: 0x000B8B34
		public unsafe XmlQualifiedName Examplar
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000BA978 File Offset: 0x000B8B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414704, RefRangeEnd = 414705, XrefRangeStart = 414693, XrefRangeEnd = 414704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSubstitutionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSubstitutionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00010F9F File Offset: 0x0000F19F
		public XmlSchemaSubstitutionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x000BA9B4 File Offset: 0x000B8BB4
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x00010FA8 File Offset: 0x0000F1A8
		public unsafe ArrayList membersList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_membersList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x000BA9E4 File Offset: 0x000B8BE4
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x00010FC7 File Offset: 0x0000F1C7
		public unsafe XmlQualifiedName examplar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroup.NativeFieldInfoPtr_examplar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_membersList;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_examplar;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Internal_get_ArrayList_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_get_Examplar_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_set_Examplar_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
