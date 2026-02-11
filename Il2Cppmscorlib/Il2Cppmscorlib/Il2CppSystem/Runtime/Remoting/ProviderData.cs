using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200029D RID: 669
	public class ProviderData : Object
	{
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000E36BC File Offset: 0x000E18BC
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderData()
		{
			Il2CppClassPointerStore<ProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderData>.NativeClassPtr);
			ProviderData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Ref");
			ProviderData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Type");
			ProviderData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Id");
			ProviderData.NativeFieldInfoPtr_CustomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomProperties");
			ProviderData.NativeFieldInfoPtr_CustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomData");
			ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100670265);
			ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100670266);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000E3778 File Offset: 0x000E1978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1378353, RefRangeEnd = 1378357, XrefRangeStart = 1378304, XrefRangeEnd = 1378353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ProviderData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000E37BC File Offset: 0x000E19BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378357, XrefRangeEnd = 1378363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x0000E558 File Offset: 0x0000C758
		public ProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x000E37F8 File Offset: 0x000E19F8
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0000E561 File Offset: 0x0000C761
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x000E3820 File Offset: 0x000E1A20
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0000E580 File Offset: 0x0000C780
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000E3848 File Offset: 0x000E1A48
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0000E59F File Offset: 0x0000C79F
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000E3870 File Offset: 0x000E1A70
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0000E5BE File Offset: 0x0000C7BE
		public unsafe Hashtable CustomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000E38A0 File Offset: 0x000E1AA0
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0000E5DD File Offset: 0x0000C7DD
		public unsafe IList CustomData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeFieldInfoPtr_CustomProperties;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeFieldInfoPtr_CustomData;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
