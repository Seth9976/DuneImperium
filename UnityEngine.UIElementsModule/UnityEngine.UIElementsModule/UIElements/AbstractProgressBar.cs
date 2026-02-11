using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007F RID: 127
	public class AbstractProgressBar : BindableElement
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x00049BD0 File Offset: 0x00047DD0
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractProgressBar()
		{
			Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AbstractProgressBar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr);
			AbstractProgressBar.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "ussClassName");
			AbstractProgressBar.NativeFieldInfoPtr_containerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "containerUssClassName");
			AbstractProgressBar.NativeFieldInfoPtr_titleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "titleUssClassName");
			AbstractProgressBar.NativeFieldInfoPtr_titleContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "titleContainerUssClassName");
			AbstractProgressBar.NativeFieldInfoPtr_progressUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "progressUssClassName");
			AbstractProgressBar.NativeFieldInfoPtr_backgroundUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "backgroundUssClassName");
			AbstractProgressBar.NativeFieldInfoPtr_m_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_Background");
			AbstractProgressBar.NativeFieldInfoPtr_m_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_Progress");
			AbstractProgressBar.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_Title");
			AbstractProgressBar.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_LowValue");
			AbstractProgressBar.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_HighValue");
			AbstractProgressBar.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "m_Value");
			AbstractProgressBar.NativeMethodInfoPtr_set_title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665121);
			AbstractProgressBar.NativeMethodInfoPtr_get_lowValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665122);
			AbstractProgressBar.NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665123);
			AbstractProgressBar.NativeMethodInfoPtr_get_highValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665124);
			AbstractProgressBar.NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665125);
			AbstractProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665126);
			AbstractProgressBar.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665127);
			AbstractProgressBar.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665128);
			AbstractProgressBar.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665129);
			AbstractProgressBar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665130);
			AbstractProgressBar.NativeMethodInfoPtr_SetProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665131);
			AbstractProgressBar.NativeMethodInfoPtr_CalculateProgressWidth_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, 100665132);
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00006BF9 File Offset: 0x00004DF9
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00049DE0 File Offset: 0x00047FE0
		public unsafe string title
		{
			get
			{
				return this.m_Title.text;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302902, XrefRangeEnd = 302903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_set_title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00049E24 File Offset: 0x00048024
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00049E60 File Offset: 0x00048060
		public unsafe float lowValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_get_lowValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302903, XrefRangeEnd = 302904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00049EA0 File Offset: 0x000480A0
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00049EDC File Offset: 0x000480DC
		public unsafe float highValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_get_highValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302904, XrefRangeEnd = 302905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00049F1C File Offset: 0x0004811C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302957, RefRangeEnd = 302958, XrefRangeStart = 302905, XrefRangeEnd = 302957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractProgressBar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00049F58 File Offset: 0x00048158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302958, XrefRangeEnd = 302959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGeometryChanged(GeometryChangedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00049F9C File Offset: 0x0004819C
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00049FE4 File Offset: 0x000481E4
		public unsafe virtual float value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302959, RefRangeEnd = 302960, XrefRangeStart = 302959, XrefRangeEnd = 302959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractProgressBar.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302960, XrefRangeEnd = 302978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractProgressBar.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0004A030 File Offset: 0x00048230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302978, XrefRangeEnd = 303021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueWithoutNotify(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0004A070 File Offset: 0x00048270
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 303030, RefRangeEnd = 303037, XrefRangeStart = 303021, XrefRangeEnd = 303030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgress(float p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_SetProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0004A0B0 File Offset: 0x000482B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303037, XrefRangeEnd = 303039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateProgressWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.NativeMethodInfoPtr_CalculateProgressWidth_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00006AD6 File Offset: 0x00004CD6
		public AbstractProgressBar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0004A0FC File Offset: 0x000482FC
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00006ADF File Offset: 0x00004CDF
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0004A11C File Offset: 0x0004831C
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006AF1 File Offset: 0x00004CF1
		public unsafe static string containerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_containerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_containerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0004A13C File Offset: 0x0004833C
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006B03 File Offset: 0x00004D03
		public unsafe static string titleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_titleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_titleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0004A15C File Offset: 0x0004835C
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00006B15 File Offset: 0x00004D15
		public unsafe static string titleContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_titleContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_titleContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0004A17C File Offset: 0x0004837C
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00006B27 File Offset: 0x00004D27
		public unsafe static string progressUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_progressUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_progressUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0004A19C File Offset: 0x0004839C
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00006B39 File Offset: 0x00004D39
		public unsafe static string backgroundUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbstractProgressBar.NativeFieldInfoPtr_backgroundUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbstractProgressBar.NativeFieldInfoPtr_backgroundUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0004A1BC File Offset: 0x000483BC
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00006B4B File Offset: 0x00004D4B
		public unsafe VisualElement m_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0004A1EC File Offset: 0x000483EC
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00006B6A File Offset: 0x00004D6A
		public unsafe VisualElement m_Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Progress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Progress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0004A21C File Offset: 0x0004841C
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00006B89 File Offset: 0x00004D89
		public unsafe Label m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0004A24C File Offset: 0x0004844C
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public unsafe float m_LowValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_LowValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_LowValue)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0004A274 File Offset: 0x00048474
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00006BC3 File Offset: 0x00004DC3
		public unsafe float m_HighValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_HighValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_HighValue)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0004A29C File Offset: 0x0004849C
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00006BDE File Offset: 0x00004DDE
		public unsafe float m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_containerUssClassName;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_titleUssClassName;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_titleContainerUssClassName;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_progressUssClassName;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_backgroundUssClassName;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_m_Background;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_m_Progress;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_set_title_Public_set_Void_String_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_get_lowValue_Public_get_Single_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_get_highValue_Public_get_Single_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Private_Void_Single_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_CalculateProgressWidth_Private_Single_Single_0;

		// Token: 0x040008DF RID: 2271
		public const float k_MinVisibleProgress = 1f;

		// Token: 0x020003B2 RID: 946
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06003920 RID: 14624 RVA: 0x000E8788 File Offset: 0x000E6988
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbstractProgressBar>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr);
				AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, "m_LowValue");
				AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, "m_HighValue");
				AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, "m_Value");
				AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, "m_Title");
				AbstractProgressBar.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, 100665134);
				AbstractProgressBar.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr, 100665135);
			}

			// Token: 0x06003921 RID: 14625 RVA: 0x000E882C File Offset: 0x000E6A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302855, XrefRangeEnd = 302865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractProgressBar.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003922 RID: 14626 RVA: 0x000E88A4 File Offset: 0x000E6AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302865, XrefRangeEnd = 302902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractProgressBar.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractProgressBar.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003923 RID: 14627 RVA: 0x00017EBA File Offset: 0x000160BA
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06003924 RID: 14628 RVA: 0x000E88E0 File Offset: 0x000E6AE0
			// (set) Token: 0x06003925 RID: 14629 RVA: 0x00017EC3 File Offset: 0x000160C3
			public unsafe UxmlFloatAttributeDescription m_LowValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_LowValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_LowValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06003926 RID: 14630 RVA: 0x000E8910 File Offset: 0x000E6B10
			// (set) Token: 0x06003927 RID: 14631 RVA: 0x00017EE2 File Offset: 0x000160E2
			public unsafe UxmlFloatAttributeDescription m_HighValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_HighValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_HighValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x06003928 RID: 14632 RVA: 0x000E8940 File Offset: 0x000E6B40
			// (set) Token: 0x06003929 RID: 14633 RVA: 0x00017F01 File Offset: 0x00016101
			public unsafe UxmlFloatAttributeDescription m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001193 RID: 4499
			// (get) Token: 0x0600392A RID: 14634 RVA: 0x000E8970 File Offset: 0x000E6B70
			// (set) Token: 0x0600392B RID: 14635 RVA: 0x00017F20 File Offset: 0x00016120
			public unsafe UxmlStringAttributeDescription m_Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Title);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractProgressBar.UxmlTraits.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002878 RID: 10360
			private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

			// Token: 0x04002879 RID: 10361
			private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

			// Token: 0x0400287A RID: 10362
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;

			// Token: 0x0400287B RID: 10363
			private static readonly IntPtr NativeFieldInfoPtr_m_Title;

			// Token: 0x0400287C RID: 10364
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400287D RID: 10365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
