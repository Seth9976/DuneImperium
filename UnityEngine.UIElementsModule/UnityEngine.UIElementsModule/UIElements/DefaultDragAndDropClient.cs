using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A2 RID: 162
	public class DefaultDragAndDropClient : DragAndDropData
	{
		// Token: 0x06000FF8 RID: 4088 RVA: 0x00055180 File Offset: 0x00053380
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDragAndDropClient()
		{
			Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DefaultDragAndDropClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr);
			DefaultDragAndDropClient.NativeFieldInfoPtr_m_GenericData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, "m_GenericData");
			DefaultDragAndDropClient.NativeFieldInfoPtr_m_DraggedInfoLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, "m_DraggedInfoLabel");
			DefaultDragAndDropClient.NativeFieldInfoPtr_m_VisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, "m_VisualMode");
			DefaultDragAndDropClient.NativeFieldInfoPtr_m_UnityObjectReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, "m_UnityObjectReferences");
			DefaultDragAndDropClient.NativeMethodInfoPtr_get_source_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665598);
			DefaultDragAndDropClient.NativeMethodInfoPtr_GetGenericData_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665599);
			DefaultDragAndDropClient.NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Void_StartDragArgs_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665600);
			DefaultDragAndDropClient.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665601);
			DefaultDragAndDropClient.NativeMethodInfoPtr_AcceptDrag_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665602);
			DefaultDragAndDropClient.NativeMethodInfoPtr_SetVisualMode_Public_Virtual_Final_New_Void_DragVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665603);
			DefaultDragAndDropClient.NativeMethodInfoPtr_DragCleanup_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665604);
			DefaultDragAndDropClient.NativeMethodInfoPtr_get_data_Public_Virtual_Final_New_get_DragAndDropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665605);
			DefaultDragAndDropClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr, 100665606);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000552B4 File Offset: 0x000534B4
		public unsafe override Object source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308714, XrefRangeEnd = 308716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultDragAndDropClient.NativeMethodInfoPtr_get_source_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00055300 File Offset: 0x00053500
		[CallerCount(0)]
		public unsafe override Object GetGenericData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultDragAndDropClient.NativeMethodInfoPtr_GetGenericData_Public_Virtual_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0005535C File Offset: 0x0005355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308716, XrefRangeEnd = 308769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartDrag(StartDragArgs args, Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Void_StartDragArgs_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000553B4 File Offset: 0x000535B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308769, XrefRangeEnd = 308778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000553F4 File Offset: 0x000535F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcceptDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_AcceptDrag_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00055428 File Offset: 0x00053628
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisualMode(DragVisualMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_SetVisualMode_Public_Virtual_Final_New_Void_DragVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00055468 File Offset: 0x00053668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308778, XrefRangeEnd = 308780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DragCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_DragCleanup_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0005549C File Offset: 0x0005369C
		public unsafe virtual DragAndDropData data
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 308780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr_get_data_Public_Virtual_Final_New_get_DragAndDropData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragAndDropData>(intPtr3) : null;
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000554DC File Offset: 0x000536DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310081, RefRangeEnd = 310082, XrefRangeStart = 310075, XrefRangeEnd = 310081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDragAndDropClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDragAndDropClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDragAndDropClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0000814C File Offset: 0x0000634C
		public DefaultDragAndDropClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00055518 File Offset: 0x00053718
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x00008155 File Offset: 0x00006355
		public unsafe Hashtable m_GenericData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_GenericData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_GenericData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00055548 File Offset: 0x00053748
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00008174 File Offset: 0x00006374
		public unsafe Label m_DraggedInfoLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_DraggedInfoLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_DraggedInfoLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00055578 File Offset: 0x00053778
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00008193 File Offset: 0x00006393
		public unsafe DragVisualMode m_VisualMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_VisualMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_VisualMode)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000555A0 File Offset: 0x000537A0
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x000081AE File Offset: 0x000063AE
		public unsafe IEnumerable<Object> m_UnityObjectReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_UnityObjectReferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDragAndDropClient.NativeFieldInfoPtr_m_UnityObjectReferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x000081CD File Offset: 0x000063CD
		public override DragVisualMode visualMode
		{
			get
			{
				return this.m_VisualMode;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000081D5 File Offset: 0x000063D5
		public override IEnumerable<Object> unityObjectReferences
		{
			get
			{
				return this.m_UnityObjectReferences;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000081DD File Offset: 0x000063DD
		public override void SetGenericData(string key, Object value)
		{
			this.m_GenericData[key] = value;
		}

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr_m_GenericData;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr_m_DraggedInfoLabel;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualMode;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_m_UnityObjectReferences;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Virtual_get_Object_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericData_Public_Virtual_Object_String_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Virtual_Final_New_Void_StartDragArgs_Vector3_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Virtual_Final_New_Void_Vector3_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_AcceptDrag_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualMode_Public_Virtual_Final_New_Void_DragVisualMode_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_DragCleanup_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_Virtual_Final_New_get_DragAndDropData_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
