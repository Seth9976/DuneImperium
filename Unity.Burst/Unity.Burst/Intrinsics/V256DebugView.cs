using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001E RID: 30
	public class V256DebugView : Object
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0000A2A0 File Offset: 0x000084A0
		// Note: this type is marked as 'beforefieldinit'.
		static V256DebugView()
		{
			Il2CppClassPointerStore<V256DebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "V256DebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr);
			V256DebugView.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, "m_Value");
			V256DebugView.NativeMethodInfoPtr__ctor_Public_Void_v256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665964);
			V256DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665965);
			V256DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665966);
			V256DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665967);
			V256DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665968);
			V256DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665969);
			V256DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665970);
			V256DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665971);
			V256DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665972);
			V256DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665973);
			V256DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr, 100665974);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000A3C0 File Offset: 0x000085C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062767, XrefRangeEnd = 1062768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe V256DebugView(v256 value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<V256DebugView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr__ctor_Public_Void_v256_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000A408 File Offset: 0x00008608
		public unsafe Il2CppStructArray<byte> Byte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062768, XrefRangeEnd = 1062771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000A448 File Offset: 0x00008648
		public unsafe Il2CppStructArray<sbyte> SByte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062771, XrefRangeEnd = 1062774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000A488 File Offset: 0x00008688
		public unsafe Il2CppStructArray<ushort> UShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062774, XrefRangeEnd = 1062777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000A4C8 File Offset: 0x000086C8
		public unsafe Il2CppStructArray<short> SShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062777, XrefRangeEnd = 1062780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000A508 File Offset: 0x00008708
		public unsafe Il2CppStructArray<uint> UInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062780, XrefRangeEnd = 1062783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000A548 File Offset: 0x00008748
		public unsafe Il2CppStructArray<int> SInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062783, XrefRangeEnd = 1062786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000A588 File Offset: 0x00008788
		public unsafe Il2CppStructArray<float> Float
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062786, XrefRangeEnd = 1062789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000A5C8 File Offset: 0x000087C8
		public unsafe Il2CppStructArray<long> SLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062789, XrefRangeEnd = 1062792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000A608 File Offset: 0x00008808
		public unsafe Il2CppStructArray<ulong> ULong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062792, XrefRangeEnd = 1062795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000A648 File Offset: 0x00008848
		public unsafe Il2CppStructArray<double> Double
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062795, XrefRangeEnd = 1062798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V256DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002D59 File Offset: 0x00000F59
		public V256DebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000A688 File Offset: 0x00008888
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002D62 File Offset: 0x00000F62
		public unsafe v256 m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V256DebugView.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V256DebugView.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_v256_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0;
	}
}
