using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200026F RID: 623
	public class TextureSlotManager : Object
	{
		// Token: 0x06002E28 RID: 11816 RVA: 0x000C4D84 File Offset: 0x000C2F84
		// Note: this type is marked as 'beforefieldinit'.
		static TextureSlotManager()
		{
			Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TextureSlotManager");
			TextureSlotManager.NativeFieldInfoPtr_k_SlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "k_SlotCount");
			TextureSlotManager.NativeFieldInfoPtr_k_SlotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "k_SlotSize");
			TextureSlotManager.NativeFieldInfoPtr_slotIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "slotIds");
			TextureSlotManager.NativeFieldInfoPtr_textureTableId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "textureTableId");
			TextureSlotManager.NativeFieldInfoPtr_m_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "m_Textures");
			TextureSlotManager.NativeFieldInfoPtr_m_Tickets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "m_Tickets");
			TextureSlotManager.NativeFieldInfoPtr_m_CurrentTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "m_CurrentTicket");
			TextureSlotManager.NativeFieldInfoPtr_m_FirstUsedTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "m_FirstUsedTicket");
			TextureSlotManager.NativeFieldInfoPtr_m_GpuTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "m_GpuTextures");
			TextureSlotManager.NativeFieldInfoPtr__FreeSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "<FreeSlots>k__BackingField");
			TextureSlotManager.NativeFieldInfoPtr_textureRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, "textureRegistry");
			TextureSlotManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670019);
			TextureSlotManager.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670020);
			TextureSlotManager.NativeMethodInfoPtr_StartNewBatch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670021);
			TextureSlotManager.NativeMethodInfoPtr_IndexOf_Public_Int32_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670022);
			TextureSlotManager.NativeMethodInfoPtr_MarkUsed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670023);
			TextureSlotManager.NativeMethodInfoPtr_get_FreeSlots_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670024);
			TextureSlotManager.NativeMethodInfoPtr_set_FreeSlots_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670025);
			TextureSlotManager.NativeMethodInfoPtr_FindOldestSlot_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670026);
			TextureSlotManager.NativeMethodInfoPtr_Bind_Public_Void_TextureId_Single_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670027);
			TextureSlotManager.NativeMethodInfoPtr_SetGpuData_Public_Void_Int32_TextureId_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr, 100670028);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000C4F50 File Offset: 0x000C3150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351936, RefRangeEnd = 351937, XrefRangeStart = 351897, XrefRangeEnd = 351936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureSlotManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureSlotManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000C4F8C File Offset: 0x000C318C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351948, RefRangeEnd = 351949, XrefRangeStart = 351937, XrefRangeEnd = 351948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000C4FC0 File Offset: 0x000C31C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351953, RefRangeEnd = 351954, XrefRangeStart = 351949, XrefRangeEnd = 351953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNewBatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_StartNewBatch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000C4FF4 File Offset: 0x000C31F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351964, RefRangeEnd = 351965, XrefRangeStart = 351954, XrefRangeEnd = 351964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(TextureId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_IndexOf_Public_Int32_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000C5040 File Offset: 0x000C3240
		[CallerCount(0)]
		public unsafe void MarkUsed(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slotIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_MarkUsed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000C5080 File Offset: 0x000C3280
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x000C50BC File Offset: 0x000C32BC
		public unsafe int FreeSlots
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_get_FreeSlots_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_set_FreeSlots_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000C50FC File Offset: 0x000C32FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351970, RefRangeEnd = 351971, XrefRangeStart = 351965, XrefRangeEnd = 351970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindOldestSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_FindOldestSlot_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000C5138 File Offset: 0x000C3338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351987, RefRangeEnd = 351988, XrefRangeStart = 351971, XrefRangeEnd = 351987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_Bind_Public_Void_TextureId_Single_Int32_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000C51A8 File Offset: 0x000C33A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351996, RefRangeEnd = 351999, XrefRangeStart = 351988, XrefRangeEnd = 351996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slotIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureSlotManager.NativeMethodInfoPtr_SetGpuData_Public_Void_Int32_TextureId_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00012FD3 File Offset: 0x000111D3
		public TextureSlotManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000C5220 File Offset: 0x000C3420
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00012FDC File Offset: 0x000111DC
		public unsafe static int k_SlotCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureSlotManager.NativeFieldInfoPtr_k_SlotCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureSlotManager.NativeFieldInfoPtr_k_SlotCount, (void*)(&value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000C523C File Offset: 0x000C343C
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x00012FEA File Offset: 0x000111EA
		public unsafe static int k_SlotSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureSlotManager.NativeFieldInfoPtr_k_SlotSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureSlotManager.NativeFieldInfoPtr_k_SlotSize, (void*)(&value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x000C5258 File Offset: 0x000C3458
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x00012FF8 File Offset: 0x000111F8
		public unsafe static Il2CppStructArray<int> slotIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureSlotManager.NativeFieldInfoPtr_slotIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureSlotManager.NativeFieldInfoPtr_slotIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000C5280 File Offset: 0x000C3480
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x0001300A File Offset: 0x0001120A
		public unsafe static int textureTableId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureSlotManager.NativeFieldInfoPtr_textureTableId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureSlotManager.NativeFieldInfoPtr_textureTableId, (void*)(&value));
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x000C529C File Offset: 0x000C349C
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x00013018 File Offset: 0x00011218
		public unsafe Il2CppStructArray<TextureId> m_Textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_Textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_Textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000C52CC File Offset: 0x000C34CC
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x00013037 File Offset: 0x00011237
		public unsafe Il2CppStructArray<int> m_Tickets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_Tickets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_Tickets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000C52FC File Offset: 0x000C34FC
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x00013056 File Offset: 0x00011256
		public unsafe int m_CurrentTicket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_CurrentTicket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_CurrentTicket)) = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000C5324 File Offset: 0x000C3524
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x00013071 File Offset: 0x00011271
		public unsafe int m_FirstUsedTicket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_FirstUsedTicket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_FirstUsedTicket)) = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000C534C File Offset: 0x000C354C
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x0001308C File Offset: 0x0001128C
		public unsafe Il2CppStructArray<Vector4> m_GpuTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_GpuTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_m_GpuTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000C537C File Offset: 0x000C357C
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x000130AB File Offset: 0x000112AB
		public unsafe int _FreeSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr__FreeSlots_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr__FreeSlots_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000C53A4 File Offset: 0x000C35A4
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x000130C6 File Offset: 0x000112C6
		public unsafe TextureRegistry textureRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_textureRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureSlotManager.NativeFieldInfoPtr_textureRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeFieldInfoPtr_k_SlotCount;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeFieldInfoPtr_k_SlotSize;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeFieldInfoPtr_slotIds;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeFieldInfoPtr_textureTableId;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeFieldInfoPtr_m_Textures;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeFieldInfoPtr_m_Tickets;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTicket;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstUsedTicket;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeFieldInfoPtr_m_GpuTextures;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeFieldInfoPtr__FreeSlots_k__BackingField;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeFieldInfoPtr_textureRegistry;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_StartNewBatch_Public_Void_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_TextureId_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_MarkUsed_Public_Void_Int32_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeSlots_Public_get_Int32_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeSlots_Private_set_Void_Int32_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_FindOldestSlot_Public_Int32_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_TextureId_Single_Int32_MaterialPropertyBlock_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_SetGpuData_Public_Void_Int32_TextureId_Int32_Int32_Single_0;
	}
}
