using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace core.animation
{
	// Token: 0x02000014 RID: 20
	public class DiceRoll : MonoBehaviour
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00005224 File Offset: 0x00003424
		// Note: this type is marked as 'beforefieldinit'.
		static DiceRoll()
		{
			Il2CppClassPointerStore<DiceRoll>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "core.animation", "DiceRoll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr);
			DiceRoll.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "ParameterName");
			DiceRoll.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "interval");
			DiceRoll.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "multiplier");
			DiceRoll.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "animator");
			DiceRoll.NativeFieldInfoPtr_RandomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "RandomKey");
			DiceRoll.NativeFieldInfoPtr_nextRoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, "nextRoll");
			DiceRoll.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, 100663395);
			DiceRoll.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, 100663396);
			DiceRoll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr, 100663397);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005308 File Offset: 0x00003508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263684, XrefRangeEnd = 1263713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiceRoll.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000533C File Offset: 0x0000353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263713, XrefRangeEnd = 1263717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiceRoll.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005370 File Offset: 0x00003570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263717, XrefRangeEnd = 1263722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiceRoll()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiceRoll>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiceRoll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000268F File Offset: 0x0000088F
		public DiceRoll(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000053AC File Offset: 0x000035AC
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002698 File Offset: 0x00000898
		public unsafe string ParameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_ParameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000053D4 File Offset: 0x000035D4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000026B7 File Offset: 0x000008B7
		public unsafe float interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_interval)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000053FC File Offset: 0x000035FC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000026D2 File Offset: 0x000008D2
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005424 File Offset: 0x00003624
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000026ED File Offset: 0x000008ED
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005454 File Offset: 0x00003654
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000270C File Offset: 0x0000090C
		public unsafe int RandomKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_RandomKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_RandomKey)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000547C File Offset: 0x0000367C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002727 File Offset: 0x00000927
		public unsafe float nextRoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_nextRoll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiceRoll.NativeFieldInfoPtr_nextRoll)) = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_ParameterName;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_interval;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_RandomKey;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_nextRoll;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
