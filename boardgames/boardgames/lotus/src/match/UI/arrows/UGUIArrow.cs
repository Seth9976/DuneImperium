using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus.src.match.UI.arrows
{
	// Token: 0x020000F3 RID: 243
	public class UGUIArrow : MonoBehaviour
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x00036330 File Offset: 0x00034530
		// Note: this type is marked as 'beforefieldinit'.
		static UGUIArrow()
		{
			Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.match.UI.arrows", "UGUIArrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr);
			UGUIArrow.NativeFieldInfoPtr_arrowRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "arrowRoot");
			UGUIArrow.NativeFieldInfoPtr_rotationRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "rotationRoot");
			UGUIArrow.NativeFieldInfoPtr_headRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "headRoot");
			UGUIArrow.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "head");
			UGUIArrow.NativeFieldInfoPtr_reticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "reticle");
			UGUIArrow.NativeFieldInfoPtr_reticleEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "reticleEmitter");
			UGUIArrow.NativeFieldInfoPtr_reticleFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "reticleFadeDuration");
			UGUIArrow.NativeFieldInfoPtr_bodyMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "bodyMask");
			UGUIArrow.NativeFieldInfoPtr_maskHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "maskHeightOffset");
			UGUIArrow.NativeFieldInfoPtr_bodyStretchZeroLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "bodyStretchZeroLength");
			UGUIArrow.NativeFieldInfoPtr_bodyStretchOneLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "bodyStretchOneLength");
			UGUIArrow.NativeFieldInfoPtr_maxUnstrestchedBodyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "maxUnstrestchedBodyLength");
			UGUIArrow.NativeFieldInfoPtr_tailGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "tailGroup");
			UGUIArrow.NativeFieldInfoPtr_tailAlphaZeroLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "tailAlphaZeroLength");
			UGUIArrow.NativeFieldInfoPtr_tailAlphaOneLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "tailAlphaOneLength");
			UGUIArrow.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "canvas");
			UGUIArrow.NativeFieldInfoPtr_showHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "showHead");
			UGUIArrow.NativeFieldInfoPtr_showReticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "showReticle");
			UGUIArrow.NativeFieldInfoPtr_previousShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, "previousShow");
			UGUIArrow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665163);
			UGUIArrow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665164);
			UGUIArrow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665165);
			UGUIArrow.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665166);
			UGUIArrow.NativeMethodInfoPtr_Show_Public_Void_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665167);
			UGUIArrow.NativeMethodInfoPtr_getPercent_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665168);
			UGUIArrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr, 100665169);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00036568 File Offset: 0x00034768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994950, XrefRangeEnd = 994955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0003659C File Offset: 0x0003479C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994955, XrefRangeEnd = 994959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000365D0 File Offset: 0x000347D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994959, XrefRangeEnd = 994971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00036604 File Offset: 0x00034804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994971, XrefRangeEnd = 994973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00036638 File Offset: 0x00034838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995024, RefRangeEnd = 995025, XrefRangeStart = 994973, XrefRangeEnd = 995024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(Vector2 sourceScreenPoint, Vector2 targetScreenPoint, bool showReticle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceScreenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetScreenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showReticle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_Show_Public_Void_Vector2_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00036694 File Offset: 0x00034894
		[CallerCount(0)]
		public unsafe float getPercent(float value, float zeroValue, float oneValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr_getPercent_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000366FC File Offset: 0x000348FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995025, XrefRangeEnd = 995026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGUIArrow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UGUIArrow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000754B File Offset: 0x0000574B
		public UGUIArrow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00036738 File Offset: 0x00034938
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00007554 File Offset: 0x00005754
		public unsafe RectTransform arrowRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_arrowRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_arrowRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00036768 File Offset: 0x00034968
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x00007573 File Offset: 0x00005773
		public unsafe RectTransform rotationRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_rotationRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_rotationRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00036798 File Offset: 0x00034998
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00007592 File Offset: 0x00005792
		public unsafe RectTransform headRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_headRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_headRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x000367C8 File Offset: 0x000349C8
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x000075B1 File Offset: 0x000057B1
		public unsafe CanvasGroup head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x000367F8 File Offset: 0x000349F8
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000075D0 File Offset: 0x000057D0
		public unsafe CanvasGroup reticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00036828 File Offset: 0x00034A28
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000075EF File Offset: 0x000057EF
		public unsafe ParticleSystem reticleEmitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticleEmitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticleEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00036858 File Offset: 0x00034A58
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0000760E File Offset: 0x0000580E
		public unsafe float reticleFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticleFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_reticleFadeDuration)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00036880 File Offset: 0x00034A80
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00007629 File Offset: 0x00005829
		public unsafe RectTransform bodyMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000368B0 File Offset: 0x00034AB0
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00007648 File Offset: 0x00005848
		public unsafe float maskHeightOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_maskHeightOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_maskHeightOffset)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000368D8 File Offset: 0x00034AD8
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00007663 File Offset: 0x00005863
		public unsafe float bodyStretchZeroLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyStretchZeroLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyStretchZeroLength)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00036900 File Offset: 0x00034B00
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000767E File Offset: 0x0000587E
		public unsafe float bodyStretchOneLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyStretchOneLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_bodyStretchOneLength)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00036928 File Offset: 0x00034B28
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00007699 File Offset: 0x00005899
		public unsafe float maxUnstrestchedBodyLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_maxUnstrestchedBodyLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_maxUnstrestchedBodyLength)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00036950 File Offset: 0x00034B50
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x000076B4 File Offset: 0x000058B4
		public unsafe CanvasGroup tailGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00036980 File Offset: 0x00034B80
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000076D3 File Offset: 0x000058D3
		public unsafe float tailAlphaZeroLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailAlphaZeroLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailAlphaZeroLength)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000369A8 File Offset: 0x00034BA8
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000076EE File Offset: 0x000058EE
		public unsafe float tailAlphaOneLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailAlphaOneLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_tailAlphaOneLength)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000369D0 File Offset: 0x00034BD0
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00007709 File Offset: 0x00005909
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00036A00 File Offset: 0x00034C00
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00007728 File Offset: 0x00005928
		public unsafe bool showHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_showHead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_showHead)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00036A28 File Offset: 0x00034C28
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00007743 File Offset: 0x00005943
		public unsafe bool showReticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_showReticle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_showReticle)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00036A50 File Offset: 0x00034C50
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0000775E File Offset: 0x0000595E
		public unsafe bool previousShow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_previousShow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrow.NativeFieldInfoPtr_previousShow)) = value;
			}
		}

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_arrowRoot;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_rotationRoot;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_headRoot;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_reticle;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_reticleEmitter;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_reticleFadeDuration;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_bodyMask;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_maskHeightOffset;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_bodyStretchZeroLength;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_bodyStretchOneLength;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_maxUnstrestchedBodyLength;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_tailGroup;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_tailAlphaZeroLength;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_tailAlphaOneLength;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_showHead;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_showReticle;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_previousShow;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_Vector2_Vector2_Boolean_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_getPercent_Private_Single_Single_Single_Single_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
