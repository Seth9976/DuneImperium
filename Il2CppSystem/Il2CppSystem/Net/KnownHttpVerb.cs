using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Specialized;

namespace Il2CppSystem.Net
{
	// Token: 0x020001BB RID: 443
	public class KnownHttpVerb : Object
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x000868DC File Offset: 0x00084ADC
		// Note: this type is marked as 'beforefieldinit'.
		static KnownHttpVerb()
		{
			Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "KnownHttpVerb");
			KnownHttpVerb.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Name");
			KnownHttpVerb.NativeFieldInfoPtr_RequireContentBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "RequireContentBody");
			KnownHttpVerb.NativeFieldInfoPtr_ContentBodyNotAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "ContentBodyNotAllowed");
			KnownHttpVerb.NativeFieldInfoPtr_ConnectRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "ConnectRequest");
			KnownHttpVerb.NativeFieldInfoPtr_ExpectNoContentResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "ExpectNoContentResponse");
			KnownHttpVerb.NativeFieldInfoPtr_NamedHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "NamedHeaders");
			KnownHttpVerb.NativeFieldInfoPtr_Get = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Get");
			KnownHttpVerb.NativeFieldInfoPtr_Connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Connect");
			KnownHttpVerb.NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Head");
			KnownHttpVerb.NativeFieldInfoPtr_Put = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Put");
			KnownHttpVerb.NativeFieldInfoPtr_Post = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "Post");
			KnownHttpVerb.NativeFieldInfoPtr_MkCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, "MkCol");
			KnownHttpVerb.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, 100667504);
			KnownHttpVerb.NativeMethodInfoPtr_Parse_Public_Static_KnownHttpVerb_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr, 100667506);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00086A1C File Offset: 0x00084C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474622, XrefRangeEnd = 474624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnownHttpVerb>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireContentBody;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentBodyNotAllowed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectRequest;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectNoContentResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownHttpVerb.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00086AA0 File Offset: 0x00084CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474624, XrefRangeEnd = 474634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KnownHttpVerb Parse(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownHttpVerb.NativeMethodInfoPtr_Parse_Public_Static_KnownHttpVerb_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr3) : null;
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0000BAC1 File Offset: 0x00009CC1
		public KnownHttpVerb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x00086AE4 File Offset: 0x00084CE4
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000BACA File Offset: 0x00009CCA
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x00086B0C File Offset: 0x00084D0C
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000BAE9 File Offset: 0x00009CE9
		public unsafe bool RequireContentBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_RequireContentBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_RequireContentBody)) = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00086B34 File Offset: 0x00084D34
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0000BB04 File Offset: 0x00009D04
		public unsafe bool ContentBodyNotAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ContentBodyNotAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ContentBodyNotAllowed)) = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00086B5C File Offset: 0x00084D5C
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0000BB1F File Offset: 0x00009D1F
		public unsafe bool ConnectRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ConnectRequest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ConnectRequest)) = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00086B84 File Offset: 0x00084D84
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000BB3A File Offset: 0x00009D3A
		public unsafe bool ExpectNoContentResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ExpectNoContentResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnownHttpVerb.NativeFieldInfoPtr_ExpectNoContentResponse)) = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00086BAC File Offset: 0x00084DAC
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0000BB55 File Offset: 0x00009D55
		public unsafe static ListDictionary NamedHeaders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_NamedHeaders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_NamedHeaders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00086BD4 File Offset: 0x00084DD4
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0000BB67 File Offset: 0x00009D67
		public unsafe static KnownHttpVerb Get
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_Get, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_Get, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00086BFC File Offset: 0x00084DFC
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000BB79 File Offset: 0x00009D79
		public unsafe static KnownHttpVerb Connect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_Connect, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_Connect, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00086C24 File Offset: 0x00084E24
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000BB8B File Offset: 0x00009D8B
		public unsafe static KnownHttpVerb Head
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_Head, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_Head, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00086C4C File Offset: 0x00084E4C
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000BB9D File Offset: 0x00009D9D
		public unsafe static KnownHttpVerb Put
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_Put, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_Put, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00086C74 File Offset: 0x00084E74
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000BBAF File Offset: 0x00009DAF
		public unsafe static KnownHttpVerb Post
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_Post, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_Post, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x00086C9C File Offset: 0x00084E9C
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000BBC1 File Offset: 0x00009DC1
		public unsafe static KnownHttpVerb MkCol
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownHttpVerb.NativeFieldInfoPtr_MkCol, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnownHttpVerb>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownHttpVerb.NativeFieldInfoPtr_MkCol, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeFieldInfoPtr_RequireContentBody;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_ContentBodyNotAllowed;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeFieldInfoPtr_ConnectRequest;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_ExpectNoContentResponse;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_NamedHeaders;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_Get;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeFieldInfoPtr_Connect;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeFieldInfoPtr_Head;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeFieldInfoPtr_Put;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeFieldInfoPtr_Post;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeFieldInfoPtr_MkCol;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_KnownHttpVerb_String_0;
	}
}
