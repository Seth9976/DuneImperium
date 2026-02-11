using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001D RID: 29
	public class V128DebugView : Object
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00009E90 File Offset: 0x00008090
		// Note: this type is marked as 'beforefieldinit'.
		static V128DebugView()
		{
			Il2CppClassPointerStore<V128DebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "V128DebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr);
			V128DebugView.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, "m_Value");
			V128DebugView.NativeMethodInfoPtr__ctor_Public_Void_v128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665953);
			V128DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665954);
			V128DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665955);
			V128DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665956);
			V128DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665957);
			V128DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665958);
			V128DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665959);
			V128DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665960);
			V128DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665961);
			V128DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665962);
			V128DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr, 100665963);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00009FB0 File Offset: 0x000081B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 629072, RefRangeEnd = 629078, XrefRangeStart = 629072, XrefRangeEnd = 629078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe V128DebugView(v128 value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<V128DebugView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr__ctor_Public_Void_v128_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00009FF8 File Offset: 0x000081F8
		public unsafe Il2CppStructArray<byte> Byte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062737, XrefRangeEnd = 1062740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000A038 File Offset: 0x00008238
		public unsafe Il2CppStructArray<sbyte> SByte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062740, XrefRangeEnd = 1062743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000A078 File Offset: 0x00008278
		public unsafe Il2CppStructArray<ushort> UShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062743, XrefRangeEnd = 1062746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public unsafe Il2CppStructArray<short> SShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062746, XrefRangeEnd = 1062749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000A0F8 File Offset: 0x000082F8
		public unsafe Il2CppStructArray<uint> UInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062749, XrefRangeEnd = 1062752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000A138 File Offset: 0x00008338
		public unsafe Il2CppStructArray<int> SInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062752, XrefRangeEnd = 1062755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000A178 File Offset: 0x00008378
		public unsafe Il2CppStructArray<float> Float
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062755, XrefRangeEnd = 1062758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000A1B8 File Offset: 0x000083B8
		public unsafe Il2CppStructArray<long> SLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062758, XrefRangeEnd = 1062761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public unsafe Il2CppStructArray<ulong> ULong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062761, XrefRangeEnd = 1062764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000A238 File Offset: 0x00008438
		public unsafe Il2CppStructArray<double> Double
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062764, XrefRangeEnd = 1062767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V128DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002D35 File Offset: 0x00000F35
		public V128DebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000A278 File Offset: 0x00008478
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002D3E File Offset: 0x00000F3E
		public unsafe v128 m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V128DebugView.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V128DebugView.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_v128_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0;
	}
}
