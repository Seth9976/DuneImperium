using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D9 RID: 473
	public class UITKTextHandle : TextHandle
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x000A4864 File Offset: 0x000A2A64
		// Note: this type is marked as 'beforefieldinit'.
		static UITKTextHandle()
		{
			Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UITKTextHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr);
			UITKTextHandle.NativeFieldInfoPtr__MeasuredSizes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "<MeasuredSizes>k__BackingField");
			UITKTextHandle.NativeFieldInfoPtr__RoundedSizes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "<RoundedSizes>k__BackingField");
			UITKTextHandle.NativeFieldInfoPtr_m_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "m_TextElement");
			UITKTextHandle.NativeFieldInfoPtr_isOverridingCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "isOverridingCursor");
			UITKTextHandle.NativeFieldInfoPtr_currentLinkIDHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "currentLinkIDHash");
			UITKTextHandle.NativeFieldInfoPtr_hasLinkTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "hasLinkTag");
			UITKTextHandle.NativeFieldInfoPtr_hasATag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "hasATag");
			UITKTextHandle.NativeFieldInfoPtr_k_MinPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, "k_MinPadding");
			UITKTextHandle.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668858);
			UITKTextHandle.NativeMethodInfoPtr_get_MeasuredSizes_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668859);
			UITKTextHandle.NativeMethodInfoPtr_set_MeasuredSizes_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668860);
			UITKTextHandle.NativeMethodInfoPtr_get_RoundedSizes_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668861);
			UITKTextHandle.NativeMethodInfoPtr_set_RoundedSizes_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668862);
			UITKTextHandle.NativeMethodInfoPtr_ComputeTextWidth_Public_Single_String_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668863);
			UITKTextHandle.NativeMethodInfoPtr_ComputeTextHeight_Public_Single_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668864);
			UITKTextHandle.NativeMethodInfoPtr_Update_Public_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668865);
			UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668866);
			UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerOver_Private_Void_PointerOverEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668867);
			UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668868);
			UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerOut_Private_Void_PointerOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668869);
			UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerDown_Internal_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668870);
			UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerUp_Internal_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668871);
			UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerMove_Internal_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668872);
			UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerOut_Private_Void_PointerOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668873);
			UITKTextHandle.NativeMethodInfoPtr_HandleLinkTag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668874);
			UITKTextHandle.NativeMethodInfoPtr_HandleATag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668875);
			UITKTextHandle.NativeMethodInfoPtr_GetTextOverflowMode_Private_TextOverflowMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668876);
			UITKTextHandle.NativeMethodInfoPtr_ConvertUssToTextGenerationSettings_Internal_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668877);
			UITKTextHandle.NativeMethodInfoPtr_TextLibraryCanElide_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668878);
			UITKTextHandle.NativeMethodInfoPtr_GetTextEffectPadding_Internal_Single_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr, 100668879);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000A4AEC File Offset: 0x000A2CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338956, RefRangeEnd = 338957, XrefRangeStart = 338951, XrefRangeEnd = 338956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITKTextHandle(TextElement te)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITKTextHandle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000A4B38 File Offset: 0x000A2D38
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x000A4B74 File Offset: 0x000A2D74
		public unsafe Vector2 MeasuredSizes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_get_MeasuredSizes_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_set_MeasuredSizes_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000A4BB4 File Offset: 0x000A2DB4
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		public unsafe Vector2 RoundedSizes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_get_RoundedSizes_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_set_RoundedSizes_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000A4C30 File Offset: 0x000A2E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338969, RefRangeEnd = 338970, XrefRangeStart = 338957, XrefRangeEnd = 338969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToMeasure);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wordWrap;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ComputeTextWidth_Public_Single_String_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000A4CA8 File Offset: 0x000A2EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338981, RefRangeEnd = 338982, XrefRangeStart = 338970, XrefRangeEnd = 338981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeTextHeight(string textToMeasure, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToMeasure);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ComputeTextHeight_Public_Single_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000A4D14 File Offset: 0x000A2F14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338994, RefRangeEnd = 338996, XrefRangeStart = 338982, XrefRangeEnd = 338994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_Update_Public_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000A4D54 File Offset: 0x000A2F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338996, XrefRangeEnd = 339010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ATagOnPointerUp(PointerUpEvent pue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000A4D98 File Offset: 0x000A2F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339010, RefRangeEnd = 339011, XrefRangeStart = 339010, XrefRangeEnd = 339010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ATagOnPointerOver(PointerOverEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerOver_Private_Void_PointerOverEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000A4DDC File Offset: 0x000A2FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339011, XrefRangeEnd = 339023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ATagOnPointerMove(PointerMoveEvent pme)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000A4E20 File Offset: 0x000A3020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339010, RefRangeEnd = 339011, XrefRangeStart = 339010, XrefRangeEnd = 339011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ATagOnPointerOut(PointerOutEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ATagOnPointerOut_Private_Void_PointerOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000A4E64 File Offset: 0x000A3064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339023, XrefRangeEnd = 339043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LinkTagOnPointerDown(PointerDownEvent pde)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pde);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerDown_Internal_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000A4EA8 File Offset: 0x000A30A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339043, XrefRangeEnd = 339063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LinkTagOnPointerUp(PointerUpEvent pue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerUp_Internal_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000A4EEC File Offset: 0x000A30EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339063, XrefRangeEnd = 339109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LinkTagOnPointerMove(PointerMoveEvent pme)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerMove_Internal_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000A4F30 File Offset: 0x000A3130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339109, XrefRangeEnd = 339122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LinkTagOnPointerOut(PointerOutEvent poe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_LinkTagOnPointerOut_Private_Void_PointerOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000A4F74 File Offset: 0x000A3174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339166, RefRangeEnd = 339167, XrefRangeStart = 339122, XrefRangeEnd = 339166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLinkTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_HandleLinkTag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000A4FA8 File Offset: 0x000A31A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339215, RefRangeEnd = 339216, XrefRangeStart = 339167, XrefRangeEnd = 339215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleATag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_HandleATag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000A4FDC File Offset: 0x000A31DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339216, XrefRangeEnd = 339222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextOverflowMode GetTextOverflowMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_GetTextOverflowMode_Private_TextOverflowMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000A5018 File Offset: 0x000A3218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339268, RefRangeEnd = 339271, XrefRangeStart = 339222, XrefRangeEnd = 339268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_ConvertUssToTextGenerationSettings_Internal_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000A505C File Offset: 0x000A325C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339273, RefRangeEnd = 339275, XrefRangeStart = 339271, XrefRangeEnd = 339273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TextLibraryCanElide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_TextLibraryCanElide_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000A5098 File Offset: 0x000A3298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339290, RefRangeEnd = 339291, XrefRangeStart = 339275, XrefRangeEnd = 339290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTextEffectPadding(FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITKTextHandle.NativeMethodInfoPtr_GetTextEffectPadding_Internal_Single_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0000F248 File Offset: 0x0000D448
		public UITKTextHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000A50E8 File Offset: 0x000A32E8
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x0000F251 File Offset: 0x0000D451
		public unsafe Vector2 _MeasuredSizes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr__MeasuredSizes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr__MeasuredSizes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000A5110 File Offset: 0x000A3310
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0000F26C File Offset: 0x0000D46C
		public unsafe Vector2 _RoundedSizes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr__RoundedSizes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr__RoundedSizes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000A5138 File Offset: 0x000A3338
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0000F287 File Offset: 0x0000D487
		public unsafe TextElement m_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_m_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_m_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000A5168 File Offset: 0x000A3368
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0000F2A6 File Offset: 0x0000D4A6
		public unsafe bool isOverridingCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_isOverridingCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_isOverridingCursor)) = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000A5190 File Offset: 0x000A3390
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0000F2C1 File Offset: 0x0000D4C1
		public unsafe int currentLinkIDHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_currentLinkIDHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_currentLinkIDHash)) = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000A51B8 File Offset: 0x000A33B8
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		public unsafe bool hasLinkTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_hasLinkTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_hasLinkTag)) = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000A51E0 File Offset: 0x000A33E0
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x0000F2F7 File Offset: 0x0000D4F7
		public unsafe bool hasATag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_hasATag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITKTextHandle.NativeFieldInfoPtr_hasATag)) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000A5208 File Offset: 0x000A3408
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0000F312 File Offset: 0x0000D512
		public unsafe static float k_MinPadding
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UITKTextHandle.NativeFieldInfoPtr_k_MinPadding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UITKTextHandle.NativeFieldInfoPtr_k_MinPadding, (void*)(&value));
			}
		}

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr__MeasuredSizes_k__BackingField;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr__RoundedSizes_k__BackingField;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElement;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeFieldInfoPtr_isOverridingCursor;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr_currentLinkIDHash;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_hasLinkTag;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_hasATag;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_k_MinPadding;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextElement_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_get_MeasuredSizes_Public_get_Vector2_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_set_MeasuredSizes_Public_set_Void_Vector2_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundedSizes_Public_get_Vector2_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundedSizes_Public_set_Void_Vector2_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTextWidth_Public_Single_String_Boolean_Single_Single_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTextHeight_Public_Single_String_Single_Single_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_TextInfo_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_ATagOnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_ATagOnPointerOver_Private_Void_PointerOverEvent_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr_ATagOnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr_ATagOnPointerOut_Private_Void_PointerOutEvent_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_LinkTagOnPointerDown_Internal_Void_PointerDownEvent_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_LinkTagOnPointerUp_Internal_Void_PointerUpEvent_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_LinkTagOnPointerMove_Internal_Void_PointerMoveEvent_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_LinkTagOnPointerOut_Private_Void_PointerOutEvent_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_HandleLinkTag_Private_Void_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_HandleATag_Private_Void_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_GetTextOverflowMode_Private_TextOverflowMode_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUssToTextGenerationSettings_Internal_Void_TextGenerationSettings_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_TextLibraryCanElide_Internal_Boolean_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_GetTextEffectPadding_Internal_Single_FontAsset_0;
	}
}
