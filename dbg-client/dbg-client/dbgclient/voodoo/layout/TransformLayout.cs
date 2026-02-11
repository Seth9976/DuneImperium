using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dbgclient.voodoo.layout
{
	// Token: 0x0200008B RID: 139
	public class TransformLayout : MonoBehaviour
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		// Note: this type is marked as 'beforefieldinit'.
		static TransformLayout()
		{
			Il2CppClassPointerStore<TransformLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "TransformLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr);
			TransformLayout.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr, "spacing");
			TransformLayout.NativeMethodInfoPtr_RebuildLayout_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr, 100664130);
			TransformLayout.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr, 100664131);
			TransformLayout.NativeMethodInfoPtr_OnChildActiveChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr, 100664132);
			TransformLayout.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr, 100664133);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0002EF48 File Offset: 0x0002D148
		[CallerCount(0)]
		public unsafe virtual void RebuildLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformLayout.NativeMethodInfoPtr_RebuildLayout_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0002EF84 File Offset: 0x0002D184
		[CallerCount(0)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayout.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		[CallerCount(0)]
		public unsafe void OnChildActiveChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayout.NativeMethodInfoPtr_OnChildActiveChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0002EFEC File Offset: 0x0002D1EC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLayout.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00004792 File Offset: 0x00002992
		public TransformLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0002F028 File Offset: 0x0002D228
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x0000479B File Offset: 0x0000299B
		public unsafe float spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLayout.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLayout.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_RebuildLayout_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Void_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_OnChildActiveChanged_Public_Void_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
