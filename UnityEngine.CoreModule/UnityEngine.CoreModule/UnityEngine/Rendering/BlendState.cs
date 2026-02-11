using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022A RID: 554
	[StructLayout(2)]
	public struct BlendState
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		// Note: this type is marked as 'beforefieldinit'.
		static BlendState()
		{
			Il2CppClassPointerStore<BlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BlendState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendState>.NativeClassPtr);
			BlendState.NativeFieldInfoPtr_m_BlendState0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState0");
			BlendState.NativeFieldInfoPtr_m_BlendState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState1");
			BlendState.NativeFieldInfoPtr_m_BlendState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState2");
			BlendState.NativeFieldInfoPtr_m_BlendState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState3");
			BlendState.NativeFieldInfoPtr_m_BlendState4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState4");
			BlendState.NativeFieldInfoPtr_m_BlendState5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState5");
			BlendState.NativeFieldInfoPtr_m_BlendState6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState6");
			BlendState.NativeFieldInfoPtr_m_BlendState7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState7");
			BlendState.NativeFieldInfoPtr_m_SeparateMRTBlendStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_SeparateMRTBlendStates");
			BlendState.NativeFieldInfoPtr_m_AlphaToMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_AlphaToMask");
			BlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_Padding");
			BlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668085);
			BlendState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668086);
			BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668087);
			BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668088);
			BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668089);
			BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668090);
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0009E974 File Offset: 0x0009CB74
		public unsafe static BlendState defaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683325, RefRangeEnd = 683326, XrefRangeStart = 683324, XrefRangeEnd = 683325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0009E9A4 File Offset: 0x0009CBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683339, RefRangeEnd = 683340, XrefRangeStart = 683326, XrefRangeEnd = 683339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendState(bool separateMRTBlend = false, bool alphaToMask = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref separateMRTBlend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaToMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0009EB0C File Offset: 0x0009CD0C
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x0009E9E4 File Offset: 0x0009CBE4
		public unsafe RenderTargetBlendState blendState0
		{
			get
			{
				return this.m_BlendState0;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0009EA18 File Offset: 0x0009CC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683348, RefRangeEnd = 683350, XrefRangeStart = 683340, XrefRangeEnd = 683348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BlendState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0009EA58 File Offset: 0x0009CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683350, XrefRangeEnd = 683354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0009EA9C File Offset: 0x0009CC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683364, RefRangeEnd = 683365, XrefRangeStart = 683354, XrefRangeEnd = 683364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0000EB28 File Offset: 0x0000CD28
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendState>.NativeClassPtr, ref this));
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0009EACC File Offset: 0x0009CCCC
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0000EB3A File Offset: 0x0000CD3A
		public bool separateMRTBlendStates
		{
			get
			{
				return Convert.ToBoolean(this.m_SeparateMRTBlendStates);
			}
			set
			{
				this.m_SeparateMRTBlendStates = Convert.ToByte(value);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x0009EAEC File Offset: 0x0009CCEC
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x0000EB49 File Offset: 0x0000CD49
		public bool alphaToMask
		{
			get
			{
				return Convert.ToBoolean(this.m_AlphaToMask);
			}
			set
			{
				this.m_AlphaToMask = Convert.ToByte(value);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0009EB24 File Offset: 0x0009CD24
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x0000EB58 File Offset: 0x0000CD58
		public RenderTargetBlendState blendState1
		{
			get
			{
				return this.m_BlendState1;
			}
			set
			{
				this.m_BlendState1 = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x0009EB3C File Offset: 0x0009CD3C
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x0000EB62 File Offset: 0x0000CD62
		public RenderTargetBlendState blendState2
		{
			get
			{
				return this.m_BlendState2;
			}
			set
			{
				this.m_BlendState2 = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x0009EB54 File Offset: 0x0009CD54
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		public RenderTargetBlendState blendState3
		{
			get
			{
				return this.m_BlendState3;
			}
			set
			{
				this.m_BlendState3 = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0009EB6C File Offset: 0x0009CD6C
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x0000EB76 File Offset: 0x0000CD76
		public RenderTargetBlendState blendState4
		{
			get
			{
				return this.m_BlendState4;
			}
			set
			{
				this.m_BlendState4 = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x0009EB84 File Offset: 0x0009CD84
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x0000EB80 File Offset: 0x0000CD80
		public RenderTargetBlendState blendState5
		{
			get
			{
				return this.m_BlendState5;
			}
			set
			{
				this.m_BlendState5 = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x0009EB9C File Offset: 0x0009CD9C
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x0000EB8A File Offset: 0x0000CD8A
		public RenderTargetBlendState blendState6
		{
			get
			{
				return this.m_BlendState6;
			}
			set
			{
				this.m_BlendState6 = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x0009EBB4 File Offset: 0x0009CDB4
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x0000EB94 File Offset: 0x0000CD94
		public RenderTargetBlendState blendState7
		{
			get
			{
				return this.m_BlendState7;
			}
			set
			{
				this.m_BlendState7 = value;
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0009EBCC File Offset: 0x0009CDCC
		public static bool operator ==(BlendState left, BlendState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		public static bool operator !=(BlendState left, BlendState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState1;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState2;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState3;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState4;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState5;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState6;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState7;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeFieldInfoPtr_m_SeparateMRTBlendStates;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaToMask;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020CE RID: 8398
		[FieldOffset(0)]
		public RenderTargetBlendState m_BlendState0;

		// Token: 0x040020CF RID: 8399
		[FieldOffset(8)]
		public RenderTargetBlendState m_BlendState1;

		// Token: 0x040020D0 RID: 8400
		[FieldOffset(16)]
		public RenderTargetBlendState m_BlendState2;

		// Token: 0x040020D1 RID: 8401
		[FieldOffset(24)]
		public RenderTargetBlendState m_BlendState3;

		// Token: 0x040020D2 RID: 8402
		[FieldOffset(32)]
		public RenderTargetBlendState m_BlendState4;

		// Token: 0x040020D3 RID: 8403
		[FieldOffset(40)]
		public RenderTargetBlendState m_BlendState5;

		// Token: 0x040020D4 RID: 8404
		[FieldOffset(48)]
		public RenderTargetBlendState m_BlendState6;

		// Token: 0x040020D5 RID: 8405
		[FieldOffset(56)]
		public RenderTargetBlendState m_BlendState7;

		// Token: 0x040020D6 RID: 8406
		[FieldOffset(64)]
		public byte m_SeparateMRTBlendStates;

		// Token: 0x040020D7 RID: 8407
		[FieldOffset(65)]
		public byte m_AlphaToMask;

		// Token: 0x040020D8 RID: 8408
		[FieldOffset(66)]
		public short m_Padding;
	}
}
