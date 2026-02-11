using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core
{
	// Token: 0x02000046 RID: 70
	public class ABSSequentiable : Object
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x0001964C File Offset: 0x0001784C
		// Note: this type is marked as 'beforefieldinit'.
		static ABSSequentiable()
		{
			Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "ABSSequentiable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr);
			ABSSequentiable.NativeFieldInfoPtr_tweenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "tweenType");
			ABSSequentiable.NativeFieldInfoPtr_sequencedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "sequencedPosition");
			ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "sequencedEndPosition");
			ABSSequentiable.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, "onStart");
			ABSSequentiable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr, 100664151);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000196E0 File Offset: 0x000178E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ABSSequentiable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ABSSequentiable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ABSSequentiable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000034EF File Offset: 0x000016EF
		public ABSSequentiable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001971C File Offset: 0x0001791C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000034F8 File Offset: 0x000016F8
		public unsafe TweenType tweenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_tweenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_tweenType)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00019744 File Offset: 0x00017944
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003513 File Offset: 0x00001713
		public unsafe float sequencedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedPosition)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001976C File Offset: 0x0001796C
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000352E File Offset: 0x0000172E
		public unsafe float sequencedEndPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_sequencedEndPosition)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00019794 File Offset: 0x00017994
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003549 File Offset: 0x00001749
		public unsafe TweenCallback onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ABSSequentiable.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_tweenType;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_sequencedPosition;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_sequencedEndPosition;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
