using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002AB RID: 683
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06002BBF RID: 11199 RVA: 0x000E6968 File Offset: 0x000E4B68
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownServiceTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr);
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_uri");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_mode");
			WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100670373);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100670374);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100670375);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100670376);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100670377);
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000E6A38 File Offset: 0x000E4C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379576, XrefRangeEnd = 1379586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x000E6AB8 File Offset: 0x000E4CB8
		public unsafe WellKnownObjectMode Mode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000E6AF4 File Offset: 0x000E4CF4
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000E6B34 File Offset: 0x000E4D34
		public unsafe string ObjectUri
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000E6B6C File Offset: 0x000E4D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379586, XrefRangeEnd = 1379601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x0000E977 File Offset: 0x0000CB77
		public WellKnownServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x000E6BB0 File Offset: 0x000E4DB0
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x0000E980 File Offset: 0x0000CB80
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x000E6BE0 File Offset: 0x000E4DE0
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x0000E99F File Offset: 0x0000CB9F
		public unsafe string obj_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000E6C08 File Offset: 0x000E4E08
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x0000E9BE File Offset: 0x0000CBBE
		public unsafe WellKnownObjectMode obj_mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode)) = value;
			}
		}

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeFieldInfoPtr_obj_uri;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeFieldInfoPtr_obj_mode;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
