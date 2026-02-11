using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x0200003C RID: 60
	public class FormatDelegate : Object
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00017D78 File Offset: 0x00015F78
		// Note: this type is marked as 'beforefieldinit'.
		static FormatDelegate()
		{
			Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "FormatDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr);
			FormatDelegate.NativeFieldInfoPtr_getFormat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr, "getFormat1");
			FormatDelegate.NativeFieldInfoPtr_getFormat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr, "getFormat2");
			FormatDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr, 100663984);
			FormatDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_3_String_IFormatProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr, 100663985);
			FormatDelegate.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr, 100663986);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00017E0C File Offset: 0x0001600C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatDelegate(Func<string, string> getFormat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getFormat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00017E58 File Offset: 0x00016058
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatDelegate(Func<string, IFormatProvider, string> getFormat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatDelegate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getFormat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_3_String_IFormatProvider_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00017EA4 File Offset: 0x000160A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069745, XrefRangeEnd = 1069746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDelegate.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00003436 File Offset: 0x00001636
		public FormatDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00017F00 File Offset: 0x00016100
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000343F File Offset: 0x0000163F
		public unsafe Func<string, string> getFormat1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDelegate.NativeFieldInfoPtr_getFormat1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDelegate.NativeFieldInfoPtr_getFormat1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00017F30 File Offset: 0x00016130
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0000345E File Offset: 0x0000165E
		public unsafe Func<string, IFormatProvider, string> getFormat2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDelegate.NativeFieldInfoPtr_getFormat2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, IFormatProvider, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDelegate.NativeFieldInfoPtr_getFormat2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_getFormat1;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_getFormat2;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_String_String_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_String_IFormatProvider_String_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
	}
}
