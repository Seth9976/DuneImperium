using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000032 RID: 50
	public class TernaryTreeReadOnly : Object
	{
		// Token: 0x0600030A RID: 778 RVA: 0x00021F7C File Offset: 0x0002017C
		// Note: this type is marked as 'beforefieldinit'.
		static TernaryTreeReadOnly()
		{
			Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "TernaryTreeReadOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr);
			TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, "nodeBuffer");
			TernaryTreeReadOnly.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, 100663712);
			TernaryTreeReadOnly.NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, 100663713);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00021FE8 File Offset: 0x000201E8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TernaryTreeReadOnly(Il2CppStructArray<byte> nodeBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TernaryTreeReadOnly.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00022034 File Offset: 0x00020234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364756, RefRangeEnd = 364759, XrefRangeStart = 364750, XrefRangeEnd = 364756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte FindCaseInsensitiveString(string stringToFind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToFind);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TernaryTreeReadOnly.NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003207 File Offset: 0x00001407
		public TernaryTreeReadOnly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00022084 File Offset: 0x00020284
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003210 File Offset: 0x00001410
		public unsafe Il2CppStructArray<byte> nodeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_nodeBuffer;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0;
	}
}
