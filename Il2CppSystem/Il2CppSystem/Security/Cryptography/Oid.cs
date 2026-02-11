using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000B4 RID: 180
	public sealed class Oid : Object
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x0004B65C File Offset: 0x0004985C
		// Note: this type is marked as 'beforefieldinit'.
		static Oid()
		{
			Il2CppClassPointerStore<Oid>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "Oid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Oid>.NativeClassPtr);
			Oid.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "_value");
			Oid.NativeFieldInfoPtr__friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "_friendlyName");
			Oid.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Oid>.NativeClassPtr, "_group");
			Oid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665119);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665120);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665121);
			Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665122);
			Oid.NativeMethodInfoPtr_FromOidValue_Public_Static_Oid_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665123);
			Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665124);
			Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665125);
			Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665126);
			Oid.NativeMethodInfoPtr__ctor_Private_Void_String_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100665127);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0004B77C File Offset: 0x0004997C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0004B7B8 File Offset: 0x000499B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 452372, RefRangeEnd = 452376, XrefRangeStart = 452366, XrefRangeEnd = 452372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0004B804 File Offset: 0x00049A04
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string value, string friendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0004B864 File Offset: 0x00049A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452376, XrefRangeEnd = 452379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(Oid oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Public_Void_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0004B8B0 File Offset: 0x00049AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452379, XrefRangeEnd = 452389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Oid FromOidValue(string oidValue, OidGroup group)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oidValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_FromOidValue_Public_Static_Oid_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0004B904 File Offset: 0x00049B04
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0004B93C File Offset: 0x00049B3C
		public unsafe string Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0004B980 File Offset: 0x00049B80
		public unsafe string FriendlyName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 452394, RefRangeEnd = 452397, XrefRangeStart = 452389, XrefRangeEnd = 452394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string value, string friendlyName, OidGroup group)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Oid.NativeMethodInfoPtr__ctor_Private_Void_String_String_OidGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00006BA6 File Offset: 0x00004DA6
		public Oid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0004BA24 File Offset: 0x00049C24
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00006BAF File Offset: 0x00004DAF
		public unsafe string _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0004BA4C File Offset: 0x00049C4C
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00006BCE File Offset: 0x00004DCE
		public unsafe string _friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0004BA74 File Offset: 0x00049C74
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00006BED File Offset: 0x00004DED
		public unsafe OidGroup _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__group);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Oid.NativeFieldInfoPtr__group)) = value;
			}
		}

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr__friendlyName;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_FromOidValue_Public_Static_Oid_String_OidGroup_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_OidGroup_0;
	}
}
