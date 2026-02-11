using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000023 RID: 35
	public class IDtdEntityInfo : Il2CppObjectBase
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0001F700 File Offset: 0x0001D900
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdEntityInfo()
		{
			Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdEntityInfo");
			IDtdEntityInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663625);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663626);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663627);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663628);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663629);
			IDtdEntityInfo.NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663630);
			IDtdEntityInfo.NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663631);
			IDtdEntityInfo.NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663632);
			IDtdEntityInfo.NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663633);
			IDtdEntityInfo.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663634);
			IDtdEntityInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663635);
			IDtdEntityInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663636);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0001F818 File Offset: 0x0001DA18
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001F85C File Offset: 0x0001DA5C
		public unsafe virtual bool IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0001F8A4 File Offset: 0x0001DAA4
		public unsafe virtual bool IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001F8EC File Offset: 0x0001DAEC
		public unsafe virtual bool IsUnparsedEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0001F934 File Offset: 0x0001DB34
		public unsafe virtual bool IsParameterEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001F97C File Offset: 0x0001DB7C
		public unsafe virtual string BaseUriString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		public unsafe virtual string DeclaredUriString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001FA04 File Offset: 0x0001DC04
		public unsafe virtual string SystemId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001FA48 File Offset: 0x0001DC48
		public unsafe virtual string PublicId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		public unsafe virtual string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001FB18 File Offset: 0x0001DD18
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002FB1 File Offset: 0x000011B1
		public IDtdEntityInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
