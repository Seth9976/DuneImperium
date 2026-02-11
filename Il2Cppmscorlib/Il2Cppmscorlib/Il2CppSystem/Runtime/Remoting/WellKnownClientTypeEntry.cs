using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A9 RID: 681
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06002BB2 RID: 11186 RVA: 0x000E66B4 File Offset: 0x000E48B4
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownClientTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr);
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_url");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "app_url");
			WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100670368);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100670369);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100670370);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100670371);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100670372);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000E6784 File Offset: 0x000E4984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379564, XrefRangeEnd = 1379574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000E67F4 File Offset: 0x000E49F4
		public unsafe string ApplicationUrl
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x000E682C File Offset: 0x000E4A2C
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000E686C File Offset: 0x000E4A6C
		public unsafe string ObjectUrl
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000E68A4 File Offset: 0x000E4AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379574, XrefRangeEnd = 1379576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0000E911 File Offset: 0x0000CB11
		public WellKnownClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000E68E8 File Offset: 0x000E4AE8
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x0000E91A File Offset: 0x0000CB1A
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000E6918 File Offset: 0x000E4B18
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x0000E939 File Offset: 0x0000CB39
		public unsafe string obj_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000E6940 File Offset: 0x000E4B40
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x0000E958 File Offset: 0x0000CB58
		public unsafe string app_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeFieldInfoPtr_obj_url;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeFieldInfoPtr_app_url;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
