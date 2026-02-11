using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class GUIContent : Object
	{
		// Token: 0x06000185 RID: 389 RVA: 0x000098A4 File Offset: 0x00007AA4
		// Note: this type is marked as 'beforefieldinit'.
		static GUIContent()
		{
			Il2CppClassPointerStore<GUIContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIContent>.NativeClassPtr);
			GUIContent.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Text");
			GUIContent.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Image");
			GUIContent.NativeFieldInfoPtr_m_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Tooltip");
			GUIContent.NativeFieldInfoPtr_OnTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "OnTextChanged");
			GUIContent.NativeFieldInfoPtr_s_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Text");
			GUIContent.NativeFieldInfoPtr_s_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Image");
			GUIContent.NativeFieldInfoPtr_s_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_TextImage");
			GUIContent.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "none");
			GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663414);
			GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663415);
			GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663416);
			GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663417);
			GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663418);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663419);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663420);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663421);
			GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663422);
			GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663423);
			GUIContent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663424);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00009A50 File Offset: 0x00007C50
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00009A88 File Offset: 0x00007C88
		public unsafe string text
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185996, RefRangeEnd = 1185997, XrefRangeStart = 1185994, XrefRangeEnd = 1185996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00009E84 File Offset: 0x00008084
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00009ACC File Offset: 0x00007CCC
		public unsafe Texture image
		{
			get
			{
				return this.m_Image;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00009B48 File Offset: 0x00007D48
		public unsafe string tooltip
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009B8C File Offset: 0x00007D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186003, RefRangeEnd = 1186004, XrefRangeStart = 1185997, XrefRangeEnd = 1186003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009BC8 File Offset: 0x00007DC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1186016, RefRangeEnd = 1186024, XrefRangeStart = 1186004, XrefRangeEnd = 1186016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009C14 File Offset: 0x00007E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186024, XrefRangeEnd = 1186034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text, Texture image, string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009C84 File Offset: 0x00007E84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1186044, RefRangeEnd = 1186048, XrefRangeStart = 1186034, XrefRangeEnd = 1186044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIContent Temp(string t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009CC8 File Offset: 0x00007EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1186067, RefRangeEnd = 1186068, XrefRangeStart = 1186048, XrefRangeEnd = 1186067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearStaticCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186068, XrefRangeEnd = 1186069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUIContent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002756 File Offset: 0x00000956
		public GUIContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00009D34 File Offset: 0x00007F34
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000275F File Offset: 0x0000095F
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00009D5C File Offset: 0x00007F5C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000277E File Offset: 0x0000097E
		public unsafe Texture m_Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00009D8C File Offset: 0x00007F8C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe string m_Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00009DB4 File Offset: 0x00007FB4
		// (set) Token: 0x06000199 RID: 409 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe Action OnTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_OnTextChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_OnTextChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00009DE4 File Offset: 0x00007FE4
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe static GUIContent s_Text
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Text, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Text, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00009E0C File Offset: 0x0000800C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000027ED File Offset: 0x000009ED
		public unsafe static GUIContent s_Image
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Image, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Image, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00009E34 File Offset: 0x00008034
		// (set) Token: 0x0600019F RID: 415 RVA: 0x000027FF File Offset: 0x000009FF
		public unsafe static GUIContent s_TextImage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_TextImage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_TextImage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009E5C File Offset: 0x0000805C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002811 File Offset: 0x00000A11
		public unsafe static GUIContent none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002823 File Offset: 0x00000A23
		public void add_OnTextChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002830 File Offset: 0x00000A30
		public void remove_OnTextChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00009E9C File Offset: 0x0000809C
		public int hash
		{
			get
			{
				int num = 0;
				bool flag = !String.IsNullOrEmpty(this.m_Text);
				if (flag)
				{
					num = this.m_Text.GetHashCode() * 37;
				}
				return num;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009ED4 File Offset: 0x000080D4
		public static GUIContent Temp(string t, string tooltip)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = tooltip;
			return GUIContent.s_Text;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009F04 File Offset: 0x00008104
		public static GUIContent Temp(Texture i)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = String.Empty;
			return GUIContent.s_Image;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009F38 File Offset: 0x00008138
		public static GUIContent Temp(Texture i, string tooltip)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = tooltip;
			return GUIContent.s_Image;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009F68 File Offset: 0x00008168
		public static GUIContent Temp(string t, Texture i)
		{
			GUIContent.s_TextImage.m_Text = t;
			GUIContent.s_TextImage.m_Image = i;
			return GUIContent.s_TextImage;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000283D File Offset: 0x00000A3D
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppStringArray texts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000284A File Offset: 0x00000A4A
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppReferenceArray<Texture> images)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_m_Image;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_m_Tooltip;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_OnTextChanged;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_s_Text;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_s_Image;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_s_TextImage;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_tooltip_Public_get_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
