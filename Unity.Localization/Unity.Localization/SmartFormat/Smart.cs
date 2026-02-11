using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000030 RID: 48
	public static class Smart : Object
	{
		// Token: 0x0600030E RID: 782 RVA: 0x000152D4 File Offset: 0x000134D4
		// Note: this type is marked as 'beforefieldinit'.
		static Smart()
		{
			Il2CppClassPointerStore<Smart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "Smart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Smart>.NativeClassPtr);
			Smart.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smart>.NativeClassPtr, "<Default>k__BackingField");
			Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663846);
			Smart.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663847);
			Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663848);
			Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663849);
			Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663850);
			Smart.NativeMethodInfoPtr_get_Default_Public_Static_get_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663851);
			Smart.NativeMethodInfoPtr_set_Default_Public_Static_set_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663852);
			Smart.NativeMethodInfoPtr_CreateDefaultSmartFormat_Public_Static_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smart>.NativeClassPtr, 100663853);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000153B8 File Offset: 0x000135B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068244, RefRangeEnd = 1068247, XrefRangeStart = 1068236, XrefRangeEnd = 1068244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00015414 File Offset: 0x00013614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068247, XrefRangeEnd = 1068255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00015484 File Offset: 0x00013684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068255, XrefRangeEnd = 1068276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000154F8 File Offset: 0x000136F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1068293, RefRangeEnd = 1068307, XrefRangeStart = 1068276, XrefRangeEnd = 1068293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00015558 File Offset: 0x00013758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068307, XrefRangeEnd = 1068320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000155A8 File Offset: 0x000137A8
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000155DC File Offset: 0x000137DC
		public unsafe static SmartFormatter Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068320, XrefRangeEnd = 1068324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_get_Default_Public_Static_get_SmartFormatter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068324, XrefRangeEnd = 1068330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_set_Default_Public_Static_set_Void_SmartFormatter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00015614 File Offset: 0x00013814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068439, RefRangeEnd = 1068441, XrefRangeStart = 1068330, XrefRangeEnd = 1068439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SmartFormatter CreateDefaultSmartFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smart.NativeMethodInfoPtr_CreateDefaultSmartFormat_Public_Static_SmartFormatter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr3) : null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003122 File Offset: 0x00001322
		public static string Format(string format, params Object[] args)
		{
			return Smart.Format(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003130 File Offset: 0x00001330
		public static string Format(IFormatProvider provider, string format, params Object[] args)
		{
			return Smart.Format(provider, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000313F File Offset: 0x0000133F
		public Smart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00015648 File Offset: 0x00013848
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003148 File Offset: 0x00001348
		public unsafe static SmartFormatter _Default_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Smart.NativeFieldInfoPtr__Default_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Smart.NativeFieldInfoPtr__Default_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_SmartFormatter_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_set_Default_Public_Static_set_Void_SmartFormatter_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultSmartFormat_Public_Static_SmartFormatter_0;
	}
}
