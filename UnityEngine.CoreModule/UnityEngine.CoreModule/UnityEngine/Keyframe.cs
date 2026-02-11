using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000065 RID: 101
	[StructLayout(2)]
	public struct Keyframe
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0001EF28 File Offset: 0x0001D128
		// Note: this type is marked as 'beforefieldinit'.
		static Keyframe()
		{
			Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Keyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
			Keyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Time");
			Keyframe.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Value");
			Keyframe.NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InTangent");
			Keyframe.NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutTangent");
			Keyframe.NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_WeightedMode");
			Keyframe.NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InWeight");
			Keyframe.NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutWeight");
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663595);
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663596);
			Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663597);
			Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663598);
			Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663599);
			Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663600);
			Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663601);
			Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663602);
			Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663603);
			Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663604);
			Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663605);
			Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663606);
			Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663607);
			Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663608);
			Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663609);
			Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663610);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001F124 File Offset: 0x0001D324
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 644314, RefRangeEnd = 644326, XrefRangeStart = 644314, XrefRangeEnd = 644314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001F164 File Offset: 0x0001D364
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 644326, RefRangeEnd = 644340, XrefRangeStart = 644326, XrefRangeEnd = 644326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe(float time, float value, float inTangent, float outTangent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inTangent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outTangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		public unsafe float time
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 644340, RefRangeEnd = 644349, XrefRangeStart = 644340, XrefRangeEnd = 644340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001F224 File Offset: 0x0001D424
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0001F254 File Offset: 0x0001D454
		public unsafe float value
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644397, RefRangeEnd = 644403, XrefRangeStart = 644397, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001F288 File Offset: 0x0001D488
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		public unsafe float inTangent
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644429, RefRangeEnd = 644431, XrefRangeStart = 644429, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001F31C File Offset: 0x0001D51C
		public unsafe float outTangent
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642841, RefRangeEnd = 642843, XrefRangeStart = 642841, XrefRangeEnd = 642843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001F350 File Offset: 0x0001D550
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0001F380 File Offset: 0x0001D580
		public unsafe float inWeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644456, RefRangeEnd = 644458, XrefRangeStart = 644456, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644458, RefRangeEnd = 644459, XrefRangeStart = 644458, XrefRangeEnd = 644458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0001F3E4 File Offset: 0x0001D5E4
		public unsafe float outWeight
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 644459, RefRangeEnd = 644463, XrefRangeStart = 644459, XrefRangeEnd = 644459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644463, RefRangeEnd = 644464, XrefRangeStart = 644463, XrefRangeEnd = 644463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001F418 File Offset: 0x0001D618
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0001F448 File Offset: 0x0001D648
		public unsafe WeightedMode weightedMode
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0001F47C File Offset: 0x0001D67C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003AB5 File Offset: 0x00001CB5
		public int tangentMode
		{
			get
			{
				return this.tangentModeInternal;
			}
			set
			{
				this.tangentModeInternal = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0001F494 File Offset: 0x0001D694
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public int tangentModeInternal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_InTangent;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_OutTangent;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_m_WeightedMode;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_m_InWeight;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_m_OutWeight;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_get_inTangent_Public_get_Single_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_get_outTangent_Public_get_Single_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_inWeight_Public_get_Single_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_outWeight_Public_get_Single_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0;

		// Token: 0x04000277 RID: 631
		[FieldOffset(0)]
		public float m_Time;

		// Token: 0x04000278 RID: 632
		[FieldOffset(4)]
		public float m_Value;

		// Token: 0x04000279 RID: 633
		[FieldOffset(8)]
		public float m_InTangent;

		// Token: 0x0400027A RID: 634
		[FieldOffset(12)]
		public float m_OutTangent;

		// Token: 0x0400027B RID: 635
		[FieldOffset(16)]
		public int m_WeightedMode;

		// Token: 0x0400027C RID: 636
		[FieldOffset(20)]
		public float m_InWeight;

		// Token: 0x0400027D RID: 637
		[FieldOffset(24)]
		public float m_OutWeight;
	}
}
