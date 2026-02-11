using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public sealed class GUIStyleState : Object
	{
		// Token: 0x0600035E RID: 862 RVA: 0x0000DA90 File Offset: 0x0000BC90
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyleState()
		{
			Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr);
			GUIStyleState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_Ptr");
			GUIStyleState.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_SourceStyle");
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663512);
			GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663513);
			GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663514);
			GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663515);
			GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663516);
			GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663517);
			GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663518);
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663519);
			GUIStyleState.get_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.get_backgroundDelegate>("UnityEngine.GUIStyleState::get_background");
			GUIStyleState.set_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.set_backgroundDelegate>("UnityEngine.GUIStyleState::set_background");
			GUIStyleState.get_textColor_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyleState.get_textColor_InjectedDelegate>("UnityEngine.GUIStyleState::get_textColor_Injected");
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000DE40 File Offset: 0x0000C040
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public unsafe Color textColor
		{
			get
			{
				Color color;
				this.get_textColor_Injected(out color);
				return color;
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1187016, RefRangeEnd = 1187040, XrefRangeStart = 1187014, XrefRangeEnd = 1187016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187040, XrefRangeEnd = 1187042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000DC28 File Offset: 0x0000BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187042, XrefRangeEnd = 1187044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187047, RefRangeEnd = 1187048, XrefRangeStart = 1187044, XrefRangeEnd = 1187047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyleState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648878, RefRangeEnd = 648880, XrefRangeStart = 648878, XrefRangeEnd = 648880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyleState(GUIStyle sourceStyle, IntPtr source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187048, XrefRangeEnd = 1187053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000DD48 File Offset: 0x0000BF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187053, XrefRangeEnd = 1187058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187058, XrefRangeEnd = 1187060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_textColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003673 File Offset: 0x00001873
		public GUIStyleState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000367C File Offset: 0x0000187C
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003697 File Offset: 0x00001897
		public unsafe GUIStyle m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000DE14 File Offset: 0x0000C014
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000036B6 File Offset: 0x000018B6
		public Texture2D background
		{
			get
			{
				IntPtr intPtr = GUIStyleState.get_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				GUIStyleState.set_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000DE58 File Offset: 0x0000C058
		public static GUIStyleState ProduceGUIStyleStateFromDeserialization(GUIStyle sourceStyle, IntPtr source)
		{
			return new GUIStyleState(sourceStyle, source);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000036CE File Offset: 0x000018CE
		public void get_textColor_Injected(out Color ret)
		{
			GUIStyleState.get_textColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000191 RID: 401
		private static readonly GUIStyleState.get_backgroundDelegate get_backgroundDelegateField;

		// Token: 0x04000192 RID: 402
		private static readonly GUIStyleState.set_backgroundDelegate set_backgroundDelegateField;

		// Token: 0x04000193 RID: 403
		private static readonly GUIStyleState.get_textColor_InjectedDelegate get_textColor_InjectedDelegateField;

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000717 RID: 1815
		private delegate IntPtr get_backgroundDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000719 RID: 1817
		private delegate void set_backgroundDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600071B RID: 1819
		private delegate void get_textColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
