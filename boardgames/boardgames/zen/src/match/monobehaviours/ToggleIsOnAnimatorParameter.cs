using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000077 RID: 119
	public class ToggleIsOnAnimatorParameter : MonoBehaviour
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x000241AC File Offset: 0x000223AC
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleIsOnAnimatorParameter()
		{
			Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "ToggleIsOnAnimatorParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr);
			ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr, "animator");
			ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr, "toggle");
			ToggleIsOnAnimatorParameter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr, 100664268);
			ToggleIsOnAnimatorParameter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr, 100664269);
			ToggleIsOnAnimatorParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr, 100664270);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00024240 File Offset: 0x00022440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988471, XrefRangeEnd = 988479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleIsOnAnimatorParameter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00024274 File Offset: 0x00022474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988479, XrefRangeEnd = 988483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleIsOnAnimatorParameter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000242A8 File Offset: 0x000224A8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleIsOnAnimatorParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleIsOnAnimatorParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleIsOnAnimatorParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00004D25 File Offset: 0x00002F25
		public ToggleIsOnAnimatorParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000242E4 File Offset: 0x000224E4
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00004D2E File Offset: 0x00002F2E
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00024314 File Offset: 0x00022514
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00004D4D File Offset: 0x00002F4D
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleIsOnAnimatorParameter.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
