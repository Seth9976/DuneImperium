using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001E6 RID: 486
	[StructLayout(2)]
	public struct HHTMLBrowser
	{
		// Token: 0x06001857 RID: 6231 RVA: 0x000773C8 File Offset: 0x000755C8
		// Note: this type is marked as 'beforefieldinit'.
		static HHTMLBrowser()
		{
			Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HHTMLBrowser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr);
			HHTMLBrowser.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, "Value");
			HHTMLBrowser.NativeMethodInfoPtr_op_Implicit_Public_Static_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667773);
			HHTMLBrowser.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667774);
			HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667775);
			HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667776);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667777);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667778);
			HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667779);
			HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667780);
			HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100667781);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000774C0 File Offset: 0x000756C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HHTMLBrowser(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Implicit_Public_Static_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00077500 File Offset: 0x00075700
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(HHTMLBrowser value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00077540 File Offset: 0x00075740
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0007756C File Offset: 0x0007576C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0007759C File Offset: 0x0007579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951547, XrefRangeEnd = 951550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000775E0 File Offset: 0x000757E0
		[CallerCount(0)]
		public unsafe bool Equals(HHTMLBrowser p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00077620 File Offset: 0x00075820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HHTMLBrowser a, HHTMLBrowser b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0007766C File Offset: 0x0007586C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HHTMLBrowser a, HHTMLBrowser b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000776B8 File Offset: 0x000758B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HHTMLBrowser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00007DD9 File Offset: 0x00005FD9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HHTMLBrowser_UInt32_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HHTMLBrowser_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0;

		// Token: 0x04001DD1 RID: 7633
		[FieldOffset(0)]
		public uint Value;
	}
}
