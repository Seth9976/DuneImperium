using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.localization
{
	// Token: 0x02000082 RID: 130
	public class LocalizedString : VersionedModel
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x000389FC File Offset: 0x00036BFC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedString()
		{
			Il2CppClassPointerStore<LocalizedString>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Canis.utils.localization", "LocalizedString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr);
			LocalizedString.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<Key>k__BackingField");
			LocalizedString.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "args");
			LocalizedString.NativeFieldInfoPtr__DisplayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "_DisplayText");
			LocalizedString.NativeFieldInfoPtr_cachedDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "cachedDisplay");
			LocalizedString.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664645);
			LocalizedString.NativeMethodInfoPtr_set_Key_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664646);
			LocalizedString.NativeMethodInfoPtr_get_DisplayText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664647);
			LocalizedString.NativeMethodInfoPtr_set_DisplayText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664648);
			LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664649);
			LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664650);
			LocalizedString.NativeMethodInfoPtr_Set_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664651);
			LocalizedString.NativeMethodInfoPtr_Set_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664652);
			LocalizedString.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664653);
			LocalizedString.NativeMethodInfoPtr_Set_Public_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664654);
			LocalizedString.NativeMethodInfoPtr_updateDisplayText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664655);
			LocalizedString.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664656);
			LocalizedString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664657);
			LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664658);
			LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664659);
			LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664660);
			LocalizedString.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664661);
			LocalizedString.NativeMethodInfoPtr_trimKey_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100664662);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00038BE4 File Offset: 0x00036DE4
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00038C1C File Offset: 0x00036E1C
		public unsafe string Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_set_Key_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00038C60 File Offset: 0x00036E60
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00038C98 File Offset: 0x00036E98
		public unsafe string DisplayText
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 862003, RefRangeEnd = 862012, XrefRangeStart = 862002, XrefRangeEnd = 862003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_DisplayText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862012, XrefRangeEnd = 862015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_set_DisplayText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00038CDC File Offset: 0x00036EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862016, RefRangeEnd = 862018, XrefRangeStart = 862015, XrefRangeEnd = 862016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00038D18 File Offset: 0x00036F18
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 862022, RefRangeEnd = 862051, XrefRangeStart = 862018, XrefRangeEnd = 862022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedString(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00038D84 File Offset: 0x00036F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 862054, RefRangeEnd = 862055, XrefRangeStart = 862051, XrefRangeEnd = 862054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Set_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00038DC8 File Offset: 0x00036FC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 862058, RefRangeEnd = 862061, XrefRangeStart = 862055, XrefRangeEnd = 862058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Set_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00038E2C File Offset: 0x0003702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862061, XrefRangeEnd = 862063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00038E60 File Offset: 0x00037060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862063, XrefRangeEnd = 862070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(LocalizableText text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Set_Public_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00038EA4 File Offset: 0x000370A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 862081, RefRangeEnd = 862085, XrefRangeStart = 862070, XrefRangeEnd = 862081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateDisplayText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_updateDisplayText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00038ED8 File Offset: 0x000370D8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862085, XrefRangeEnd = 862087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00038F20 File Offset: 0x00037120
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 862003, RefRangeEnd = 862012, XrefRangeStart = 862003, XrefRangeEnd = 862012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00038F64 File Offset: 0x00037164
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 862088, RefRangeEnd = 862092, XrefRangeStart = 862087, XrefRangeEnd = 862088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(LocalizedString other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00038FA0 File Offset: 0x000371A0
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 862094, RefRangeEnd = 862126, XrefRangeStart = 862092, XrefRangeEnd = 862094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator LocalizedString(string other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00038FE4 File Offset: 0x000371E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862128, RefRangeEnd = 862130, XrefRangeStart = 862126, XrefRangeEnd = 862128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LocalizedString(LocalizableText other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_LocalizableText_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00039028 File Offset: 0x00037228
		[CallerCount(0)]
		public unsafe static bool IsNullOrEmpty(LocalizedString ls)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ls);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_LocalizedString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003906C File Offset: 0x0003726C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862130, XrefRangeEnd = 862132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string trimKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_trimKey_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00005677 File Offset: 0x00003877
		public LocalizedString(string key, params Object[] args)
			: this(key, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00005686 File Offset: 0x00003886
		public void Set(string key, params Object[] args)
		{
			this.Set(key, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00005695 File Offset: 0x00003895
		public LocalizedString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000390A8 File Offset: 0x000372A8
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0000569E File Offset: 0x0000389E
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000390D0 File Offset: 0x000372D0
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x000056BD File Offset: 0x000038BD
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00039100 File Offset: 0x00037300
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x000056DC File Offset: 0x000038DC
		public unsafe string _DisplayText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__DisplayText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__DisplayText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00039128 File Offset: 0x00037328
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000056FB File Offset: 0x000038FB
		public unsafe ulong cachedDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_cachedDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_cachedDisplay)) = value;
			}
		}

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr__DisplayText;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_cachedDisplay;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Private_set_Void_String_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayText_Public_get_String_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayText_Private_set_Void_String_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_LocalizableText_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_updateDisplayText_Private_Void_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizedString_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_String_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LocalizedString_LocalizableText_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_LocalizedString_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_trimKey_Private_Static_String_String_0;
	}
}
