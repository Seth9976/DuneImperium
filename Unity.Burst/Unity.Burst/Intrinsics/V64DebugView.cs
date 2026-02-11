using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001C RID: 28
	public class V64DebugView : Object
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00009A80 File Offset: 0x00007C80
		// Note: this type is marked as 'beforefieldinit'.
		static V64DebugView()
		{
			Il2CppClassPointerStore<V64DebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "V64DebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr);
			V64DebugView.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, "m_Value");
			V64DebugView.NativeMethodInfoPtr__ctor_Public_Void_v64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665942);
			V64DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665943);
			V64DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665944);
			V64DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665945);
			V64DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665946);
			V64DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665947);
			V64DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665948);
			V64DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665949);
			V64DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665950);
			V64DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665951);
			V64DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr, 100665952);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062706, XrefRangeEnd = 1062707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe V64DebugView(v64 value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<V64DebugView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr__ctor_Public_Void_v64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00009BE8 File Offset: 0x00007DE8
		public unsafe Il2CppStructArray<byte> Byte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062707, XrefRangeEnd = 1062710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00009C28 File Offset: 0x00007E28
		public unsafe Il2CppStructArray<sbyte> SByte
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062710, XrefRangeEnd = 1062713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00009C68 File Offset: 0x00007E68
		public unsafe Il2CppStructArray<ushort> UShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062713, XrefRangeEnd = 1062716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00009CA8 File Offset: 0x00007EA8
		public unsafe Il2CppStructArray<short> SShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062716, XrefRangeEnd = 1062719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public unsafe Il2CppStructArray<uint> UInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062719, XrefRangeEnd = 1062722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00009D28 File Offset: 0x00007F28
		public unsafe Il2CppStructArray<int> SInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062722, XrefRangeEnd = 1062725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00009D68 File Offset: 0x00007F68
		public unsafe Il2CppStructArray<float> Float
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062725, XrefRangeEnd = 1062728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00009DA8 File Offset: 0x00007FA8
		public unsafe Il2CppStructArray<long> SLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062728, XrefRangeEnd = 1062731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00009DE8 File Offset: 0x00007FE8
		public unsafe Il2CppStructArray<ulong> ULong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062731, XrefRangeEnd = 1062734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00009E28 File Offset: 0x00008028
		public unsafe Il2CppStructArray<double> Double
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062734, XrefRangeEnd = 1062737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(V64DebugView.NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002D11 File Offset: 0x00000F11
		public V64DebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00009E68 File Offset: 0x00008068
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002D1A File Offset: 0x00000F1A
		public unsafe v64 m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V64DebugView.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(V64DebugView.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_v64_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_get_Byte_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_SByte_Public_get_Il2CppStructArray_1_SByte_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_UShort_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_SShort_Public_get_Il2CppStructArray_1_Int16_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_UInt_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_SInt_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_Float_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_SLong_Public_get_Il2CppStructArray_1_Int64_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_ULong_Public_get_Il2CppStructArray_1_UInt64_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_Double_Public_get_Il2CppStructArray_1_Double_0;
	}
}
