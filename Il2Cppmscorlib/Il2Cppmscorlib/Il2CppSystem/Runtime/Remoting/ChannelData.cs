using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200029C RID: 668
	public class ChannelData : Object
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x000E332C File Offset: 0x000E152C
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelData()
		{
			Il2CppClassPointerStore<ChannelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelData>.NativeClassPtr);
			ChannelData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Ref");
			ChannelData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Type");
			ChannelData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Id");
			ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "DelayLoadAsClientChannel");
			ChannelData.NativeFieldInfoPtr__serverProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_serverProviders");
			ChannelData.NativeFieldInfoPtr__clientProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_clientProviders");
			ChannelData.NativeFieldInfoPtr__customProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_customProperties");
			ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100670260);
			ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100670261);
			ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100670262);
			ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100670263);
			ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100670264);
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000E344C File Offset: 0x000E164C
		public unsafe ArrayList ServerProviders
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1378181, RefRangeEnd = 1378185, XrefRangeStart = 1378176, XrefRangeEnd = 1378181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000E348C File Offset: 0x000E168C
		public unsafe ArrayList ClientProviders
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1378190, RefRangeEnd = 1378194, XrefRangeStart = 1378185, XrefRangeEnd = 1378190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000E34CC File Offset: 0x000E16CC
		public unsafe Hashtable CustomProperties
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1378199, RefRangeEnd = 1378204, XrefRangeStart = 1378194, XrefRangeEnd = 1378199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000E350C File Offset: 0x000E170C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378288, RefRangeEnd = 1378289, XrefRangeStart = 1378204, XrefRangeEnd = 1378288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ChannelData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000E3550 File Offset: 0x000E1750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378289, XrefRangeEnd = 1378304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0000E476 File Offset: 0x0000C676
		public ChannelData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000E358C File Offset: 0x000E178C
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x0000E47F File Offset: 0x0000C67F
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x000E35B4 File Offset: 0x000E17B4
		// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0000E49E File Offset: 0x0000C69E
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000E35DC File Offset: 0x000E17DC
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0000E4BD File Offset: 0x0000C6BD
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000E3604 File Offset: 0x000E1804
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x0000E4DC File Offset: 0x0000C6DC
		public unsafe string DelayLoadAsClientChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000E362C File Offset: 0x000E182C
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0000E4FB File Offset: 0x0000C6FB
		public unsafe ArrayList _serverProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000E365C File Offset: 0x000E185C
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0000E51A File Offset: 0x0000C71A
		public unsafe ArrayList _clientProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x000E368C File Offset: 0x000E188C
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0000E539 File Offset: 0x0000C739
		public unsafe Hashtable _customProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_DelayLoadAsClientChannel;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr__serverProviders;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeFieldInfoPtr__clientProviders;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeFieldInfoPtr__customProperties;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
