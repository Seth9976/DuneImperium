using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.zen.match.renderer
{
	// Token: 0x0200004A RID: 74
	public class RandomAnimatorSpeed : MonoBehaviour
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0001A85C File Offset: 0x00018A5C
		// Note: this type is marked as 'beforefieldinit'.
		static RandomAnimatorSpeed()
		{
			Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.zen.match.renderer", "RandomAnimatorSpeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr);
			RandomAnimatorSpeed.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr, "min");
			RandomAnimatorSpeed.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr, "max");
			RandomAnimatorSpeed.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr, 100663812);
			RandomAnimatorSpeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr, 100663813);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001A8DC File Offset: 0x00018ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985484, XrefRangeEnd = 985490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAnimatorSpeed.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001A910 File Offset: 0x00018B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985490, XrefRangeEnd = 985491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomAnimatorSpeed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomAnimatorSpeed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAnimatorSpeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000341F File Offset: 0x0000161F
		public RandomAnimatorSpeed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001A94C File Offset: 0x00018B4C
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003428 File Offset: 0x00001628
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAnimatorSpeed.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAnimatorSpeed.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0001A974 File Offset: 0x00018B74
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00003443 File Offset: 0x00001643
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAnimatorSpeed.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAnimatorSpeed.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
