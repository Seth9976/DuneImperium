using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000012 RID: 18
	public class BitStack : Object
	{
		// Token: 0x0600018F RID: 399 RVA: 0x0001BD28 File Offset: 0x00019F28
		// Note: this type is marked as 'beforefieldinit'.
		static BitStack()
		{
			Il2CppClassPointerStore<BitStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BitStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitStack>.NativeClassPtr);
			BitStack.NativeFieldInfoPtr_bitStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "bitStack");
			BitStack.NativeFieldInfoPtr_stackPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "stackPos");
			BitStack.NativeFieldInfoPtr_curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "curr");
			BitStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663512);
			BitStack.NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663513);
			BitStack.NativeMethodInfoPtr_PopBit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663514);
			BitStack.NativeMethodInfoPtr_PeekBit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663515);
			BitStack.NativeMethodInfoPtr_PushCurr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663516);
			BitStack.NativeMethodInfoPtr_PopCurr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663517);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001BE0C File Offset: 0x0001A00C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364097, RefRangeEnd = 364100, XrefRangeStart = 364096, XrefRangeEnd = 364097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001BE48 File Offset: 0x0001A048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364108, RefRangeEnd = 364111, XrefRangeStart = 364100, XrefRangeEnd = 364108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushBit(bool bit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001BE88 File Offset: 0x0001A088
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 364111, RefRangeEnd = 364117, XrefRangeStart = 364111, XrefRangeEnd = 364111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PopBit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 364117, RefRangeEnd = 364125, XrefRangeStart = 364117, XrefRangeEnd = 364117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PeekBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PeekBit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001BF00 File Offset: 0x0001A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364125, XrefRangeEnd = 364133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushCurr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PushCurr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001BF34 File Offset: 0x0001A134
		[CallerCount(0)]
		public unsafe void PopCurr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PopCurr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002A62 File Offset: 0x00000C62
		public BitStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0001BF68 File Offset: 0x0001A168
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002A6B File Offset: 0x00000C6B
		public unsafe Il2CppStructArray<uint> bitStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_bitStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_bitStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0001BF98 File Offset: 0x0001A198
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002A8A File Offset: 0x00000C8A
		public unsafe int stackPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_stackPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_stackPos)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002AA5 File Offset: 0x00000CA5
		public unsafe uint curr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_curr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_curr)) = value;
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_bitStack;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_stackPos;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_curr;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_PopBit_Public_Boolean_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_PeekBit_Public_Boolean_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_PushCurr_Private_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_PopCurr_Private_Void_0;
	}
}
