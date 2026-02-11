using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001A RID: 26
	public class AspectRatioFitter : UIBehaviour
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00014C4C File Offset: 0x00012E4C
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioFitter()
		{
			Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "AspectRatioFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr);
			AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_AspectMode");
			AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_AspectRatio");
			AspectRatioFitter.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_Rect");
			AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_DelayedSetDirty");
			AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_DoesParentExist");
			AspectRatioFitter.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_Tracker");
			AspectRatioFitter.NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663875);
			AspectRatioFitter.NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663876);
			AspectRatioFitter.NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663877);
			AspectRatioFitter.NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663878);
			AspectRatioFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663879);
			AspectRatioFitter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663880);
			AspectRatioFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663881);
			AspectRatioFitter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663882);
			AspectRatioFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663883);
			AspectRatioFitter.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663884);
			AspectRatioFitter.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663885);
			AspectRatioFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663886);
			AspectRatioFitter.NativeMethodInfoPtr_UpdateRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663887);
			AspectRatioFitter.NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663888);
			AspectRatioFitter.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663889);
			AspectRatioFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663890);
			AspectRatioFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663891);
			AspectRatioFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663892);
			AspectRatioFitter.NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663893);
			AspectRatioFitter.NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663894);
			AspectRatioFitter.NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663895);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00014E98 File Offset: 0x00013098
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00014ED4 File Offset: 0x000130D4
		public unsafe AspectRatioFitter.AspectMode aspectMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1087862, RefRangeEnd = 1087863, XrefRangeStart = 1087858, XrefRangeEnd = 1087862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00014F14 File Offset: 0x00013114
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00014F50 File Offset: 0x00013150
		public unsafe float aspectRatio
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1087867, RefRangeEnd = 1087868, XrefRangeStart = 1087863, XrefRangeEnd = 1087867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00014F90 File Offset: 0x00013190
		public unsafe RectTransform rectTransform
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1087876, RefRangeEnd = 1087894, XrefRangeStart = 1087868, XrefRangeEnd = 1087876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00014FD0 File Offset: 0x000131D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087894, XrefRangeEnd = 1087895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001500C File Offset: 0x0001320C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087895, XrefRangeEnd = 1087904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00015048 File Offset: 0x00013248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087904, XrefRangeEnd = 1087907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00015084 File Offset: 0x00013284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087907, XrefRangeEnd = 1087914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000150C0 File Offset: 0x000132C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087914, XrefRangeEnd = 1087923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000150FC File Offset: 0x000132FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087923, XrefRangeEnd = 1087924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00015138 File Offset: 0x00013338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087924, XrefRangeEnd = 1087925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00015174 File Offset: 0x00013374
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1087961, RefRangeEnd = 1087968, XrefRangeStart = 1087925, XrefRangeEnd = 1087961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_UpdateRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000151A8 File Offset: 0x000133A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087968, XrefRangeEnd = 1087976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSizeDeltaToProduceSize(float size, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00015200 File Offset: 0x00013400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087986, RefRangeEnd = 1087990, XrefRangeStart = 1087976, XrefRangeEnd = 1087986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetParentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001523C File Offset: 0x0001343C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00015278 File Offset: 0x00013478
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000152B4 File Offset: 0x000134B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000152E8 File Offset: 0x000134E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088000, RefRangeEnd = 1088002, XrefRangeStart = 1087990, XrefRangeEnd = 1088000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsComponentValidOnObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00015324 File Offset: 0x00013524
		[CallerCount(0)]
		public unsafe bool IsAspectModeValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00015360 File Offset: 0x00013560
		[CallerCount(0)]
		public unsafe bool DoesParentExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00003368 File Offset: 0x00001568
		public AspectRatioFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001539C File Offset: 0x0001359C
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003371 File Offset: 0x00001571
		public unsafe AspectRatioFitter.AspectMode m_AspectMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000153C4 File Offset: 0x000135C4
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000338C File Offset: 0x0000158C
		public unsafe float m_AspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000153EC File Offset: 0x000135EC
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000033A7 File Offset: 0x000015A7
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0001541C File Offset: 0x0001361C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000033C6 File Offset: 0x000015C6
		public unsafe bool m_DelayedSetDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00015444 File Offset: 0x00013644
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000033E1 File Offset: 0x000015E1
		public unsafe bool m_DoesParentExist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0001546C File Offset: 0x0001366C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x000033FC File Offset: 0x000015FC
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_m_AspectMode;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_m_AspectRatio;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedSetDirty;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_m_DoesParentExist;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRect_Private_Void_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0;

		// Token: 0x0200009B RID: 155
		public enum AspectMode
		{
			// Token: 0x04000985 RID: 2437
			None,
			// Token: 0x04000986 RID: 2438
			WidthControlsHeight,
			// Token: 0x04000987 RID: 2439
			HeightControlsWidth,
			// Token: 0x04000988 RID: 2440
			FitInParent,
			// Token: 0x04000989 RID: 2441
			EnvelopeParent
		}
	}
}
