using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000075 RID: 117
	public class SetViewLayer : Observer
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00020658 File Offset: 0x0001E858
		// Note: this type is marked as 'beforefieldinit'.
		static SetViewLayer()
		{
			Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "SetViewLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr);
			SetViewLayer.NativeFieldInfoPtr_ViewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, "ViewLayer");
			SetViewLayer.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, "entity");
			SetViewLayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, 100664253);
			SetViewLayer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, 100664254);
			SetViewLayer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, 100664255);
			SetViewLayer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, 100664256);
			SetViewLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr, 100664257);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00020714 File Offset: 0x0001E914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113971, XrefRangeEnd = 1113983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetViewLayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00020750 File Offset: 0x0001E950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetViewLayer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00020784 File Offset: 0x0001E984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113983, XrefRangeEnd = 1113985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetViewLayer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000207C0 File Offset: 0x0001E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetViewLayer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000207F4 File Offset: 0x0001E9F4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetViewLayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetViewLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetViewLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000056B5 File Offset: 0x000038B5
		public SetViewLayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00020830 File Offset: 0x0001EA30
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000056BE File Offset: 0x000038BE
		public unsafe int ViewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetViewLayer.NativeFieldInfoPtr_ViewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetViewLayer.NativeFieldInfoPtr_ViewLayer)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00020858 File Offset: 0x0001EA58
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x000056D9 File Offset: 0x000038D9
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetViewLayer.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetViewLayer.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_ViewLayer;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
