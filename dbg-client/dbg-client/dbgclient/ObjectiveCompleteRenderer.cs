using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient
{
	// Token: 0x02000080 RID: 128
	public class ObjectiveCompleteRenderer : VersionedSubscriber<ObjectiveData>
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x0002D02C File Offset: 0x0002B22C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectiveCompleteRenderer()
		{
			Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "ObjectiveCompleteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr);
			ObjectiveCompleteRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr, "animator");
			ObjectiveCompleteRenderer.NativeFieldInfoPtr_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr, "Complete");
			ObjectiveCompleteRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr, 100664040);
			ObjectiveCompleteRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr, 100664041);
			ObjectiveCompleteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr, 100664042);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501297, XrefRangeEnd = 501301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectiveCompleteRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501301, XrefRangeEnd = 501308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectiveCompleteRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002D138 File Offset: 0x0002B338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501308, XrefRangeEnd = 501311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectiveCompleteRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveCompleteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveCompleteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000440C File Offset: 0x0000260C
		public ObjectiveCompleteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0002D174 File Offset: 0x0002B374
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004415 File Offset: 0x00002615
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveCompleteRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveCompleteRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0002D1A4 File Offset: 0x0002B3A4
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004434 File Offset: 0x00002634
		public unsafe static int Complete
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjectiveCompleteRenderer.NativeFieldInfoPtr_Complete, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectiveCompleteRenderer.NativeFieldInfoPtr_Complete, (void*)(&value));
			}
		}

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_Complete;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
