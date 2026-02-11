using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000AB RID: 171
	[Serializable]
	public class PreserveTags : Object
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x0002A180 File Offset: 0x00028380
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveTags()
		{
			Il2CppClassPointerStore<PreserveTags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "PreserveTags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr);
			PreserveTags.NativeFieldInfoPtr_m_Opening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, "m_Opening");
			PreserveTags.NativeFieldInfoPtr_m_Closing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, "m_Closing");
			PreserveTags.NativeMethodInfoPtr_get_Opening_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664814);
			PreserveTags.NativeMethodInfoPtr_set_Opening_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664815);
			PreserveTags.NativeMethodInfoPtr_get_Closing_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664816);
			PreserveTags.NativeMethodInfoPtr_set_Closing_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664817);
			PreserveTags.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664818);
			PreserveTags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr, 100664819);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0002A250 File Offset: 0x00028450
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0002A28C File Offset: 0x0002848C
		public unsafe char Opening
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr_get_Opening_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr_set_Opening_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0002A2CC File Offset: 0x000284CC
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0002A308 File Offset: 0x00028508
		public unsafe char Closing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr_get_Closing_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr_set_Closing_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002A348 File Offset: 0x00028548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076823, XrefRangeEnd = 1076869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0002A38C File Offset: 0x0002858C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076869, XrefRangeEnd = 1076870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveTags()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveTags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveTags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000053E0 File Offset: 0x000035E0
		public PreserveTags(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0002A3C8 File Offset: 0x000285C8
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000053E9 File Offset: 0x000035E9
		public unsafe char m_Opening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreserveTags.NativeFieldInfoPtr_m_Opening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreserveTags.NativeFieldInfoPtr_m_Opening)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0002A3F0 File Offset: 0x000285F0
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00005404 File Offset: 0x00003604
		public unsafe char m_Closing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreserveTags.NativeFieldInfoPtr_m_Closing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreserveTags.NativeFieldInfoPtr_m_Closing)) = value;
			}
		}

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_m_Opening;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_m_Closing;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_get_Opening_Public_get_Char_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_set_Opening_Public_set_Void_Char_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_get_Closing_Public_get_Char_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_set_Closing_Public_set_Void_Char_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Virtual_Final_New_Void_Message_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
