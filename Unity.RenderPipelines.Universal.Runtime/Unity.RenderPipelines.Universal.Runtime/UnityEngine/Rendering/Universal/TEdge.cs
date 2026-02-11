using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000018 RID: 24
	public class TEdge : Object
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00018668 File Offset: 0x00016868
		// Note: this type is marked as 'beforefieldinit'.
		static TEdge()
		{
			Il2CppClassPointerStore<TEdge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TEdge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TEdge>.NativeClassPtr);
			TEdge.NativeFieldInfoPtr_Bot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Bot");
			TEdge.NativeFieldInfoPtr_Curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Curr");
			TEdge.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Top");
			TEdge.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Delta");
			TEdge.NativeFieldInfoPtr_Dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Dx");
			TEdge.NativeFieldInfoPtr_PolyTyp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "PolyTyp");
			TEdge.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Side");
			TEdge.NativeFieldInfoPtr_WindDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "WindDelta");
			TEdge.NativeFieldInfoPtr_WindCnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "WindCnt");
			TEdge.NativeFieldInfoPtr_WindCnt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "WindCnt2");
			TEdge.NativeFieldInfoPtr_OutIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "OutIdx");
			TEdge.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Next");
			TEdge.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "Prev");
			TEdge.NativeFieldInfoPtr_NextInLML = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "NextInLML");
			TEdge.NativeFieldInfoPtr_NextInAEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "NextInAEL");
			TEdge.NativeFieldInfoPtr_PrevInAEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "PrevInAEL");
			TEdge.NativeFieldInfoPtr_NextInSEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "NextInSEL");
			TEdge.NativeFieldInfoPtr_PrevInSEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TEdge>.NativeClassPtr, "PrevInSEL");
			TEdge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TEdge>.NativeClassPtr, 100663427);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00018814 File Offset: 0x00016A14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEdge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TEdge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TEdge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000025C1 File Offset: 0x000007C1
		public TEdge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00018850 File Offset: 0x00016A50
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000025CA File Offset: 0x000007CA
		public unsafe IntPoint Bot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Bot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Bot)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00018878 File Offset: 0x00016A78
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe IntPoint Curr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Curr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Curr)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000188A0 File Offset: 0x00016AA0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe IntPoint Top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Top)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000188C8 File Offset: 0x00016AC8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000261B File Offset: 0x0000081B
		public unsafe IntPoint Delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Delta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Delta)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000188F0 File Offset: 0x00016AF0
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002636 File Offset: 0x00000836
		public unsafe double Dx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Dx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Dx)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00018918 File Offset: 0x00016B18
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002651 File Offset: 0x00000851
		public unsafe PolyType PolyTyp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PolyTyp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PolyTyp)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00018940 File Offset: 0x00016B40
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000266C File Offset: 0x0000086C
		public unsafe EdgeSide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00018968 File Offset: 0x00016B68
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002687 File Offset: 0x00000887
		public unsafe int WindDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindDelta)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00018990 File Offset: 0x00016B90
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000026A2 File Offset: 0x000008A2
		public unsafe int WindCnt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindCnt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindCnt)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000189B8 File Offset: 0x00016BB8
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000026BD File Offset: 0x000008BD
		public unsafe int WindCnt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindCnt2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_WindCnt2)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000189E0 File Offset: 0x00016BE0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000026D8 File Offset: 0x000008D8
		public unsafe int OutIdx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_OutIdx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_OutIdx)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00018A08 File Offset: 0x00016C08
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000026F3 File Offset: 0x000008F3
		public unsafe TEdge Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00018A38 File Offset: 0x00016C38
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002712 File Offset: 0x00000912
		public unsafe TEdge Prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00018A68 File Offset: 0x00016C68
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002731 File Offset: 0x00000931
		public unsafe TEdge NextInLML
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInLML);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInLML), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00018A98 File Offset: 0x00016C98
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002750 File Offset: 0x00000950
		public unsafe TEdge NextInAEL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInAEL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInAEL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00018AC8 File Offset: 0x00016CC8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000276F File Offset: 0x0000096F
		public unsafe TEdge PrevInAEL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PrevInAEL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PrevInAEL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00018AF8 File Offset: 0x00016CF8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000278E File Offset: 0x0000098E
		public unsafe TEdge NextInSEL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInSEL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_NextInSEL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00018B28 File Offset: 0x00016D28
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe TEdge PrevInSEL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PrevInSEL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TEdge.NativeFieldInfoPtr_PrevInSEL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_Bot;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_Curr;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_Delta;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_Dx;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_PolyTyp;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_WindDelta;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_WindCnt;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_WindCnt2;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_OutIdx;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_Prev;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_NextInLML;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_NextInAEL;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_PrevInAEL;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_NextInSEL;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_PrevInSEL;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
