using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200006C RID: 108
	public class TMP_TextParsingUtilities : Object
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x000381B0 File Offset: 0x000363B0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextParsingUtilities()
		{
			Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextParsingUtilities");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "s_Instance");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringL");
			TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringU");
			TMP_TextParsingUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664826);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664827);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664828);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664829);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664830);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664831);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664832);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664833);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664834);
			TMP_TextParsingUtilities.NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664835);
			TMP_TextParsingUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664836);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000382F0 File Offset: 0x000364F0
		public unsafe static TMP_TextParsingUtilities instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049608, XrefRangeEnd = 1049612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00038324 File Offset: 0x00036524
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1049620, RefRangeEnd = 1049624, XrefRangeStart = 1049612, XrefRangeEnd = 1049620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00038368 File Offset: 0x00036568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049626, RefRangeEnd = 1049628, XrefRangeStart = 1049624, XrefRangeEnd = 1049626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeCaseSensitive(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000383AC File Offset: 0x000365AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049628, XrefRangeEnd = 1049631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerASCIIFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000383EC File Offset: 0x000365EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1049634, RefRangeEnd = 1049638, XrefRangeStart = 1049631, XrefRangeEnd = 1049634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperASCIIFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0003842C File Offset: 0x0003662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049638, XrefRangeEnd = 1049641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0003846C File Offset: 0x0003666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049641, XrefRangeEnd = 1049644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToLowerASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000384AC File Offset: 0x000366AC
		[CallerCount(0)]
		public unsafe static bool IsHighSurrogate(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000384EC File Offset: 0x000366EC
		[CallerCount(0)]
		public unsafe static bool IsLowSurrogate(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003852C File Offset: 0x0003672C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049644, RefRangeEnd = 1049645, XrefRangeStart = 1049644, XrefRangeEnd = 1049644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00038578 File Offset: 0x00036778
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextParsingUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextParsingUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00008980 File Offset: 0x00006B80
		public TMP_TextParsingUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x000385B4 File Offset: 0x000367B4
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00008989 File Offset: 0x00006B89
		public unsafe static TMP_TextParsingUtilities s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x000385DC File Offset: 0x000367DC
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0000899B File Offset: 0x00006B9B
		public unsafe static string k_LookupStringL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000385FC File Offset: 0x000367FC
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x000089AD File Offset: 0x00006BAD
		public unsafe static string k_LookupStringU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextParsingUtilities.NativeFieldInfoPtr_k_LookupStringU, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_k_LookupStringL;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_k_LookupStringU;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
