using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F0 RID: 240
	public class Cursor : Object
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x0005F670 File Offset: 0x0005D870
		// Note: this type is marked as 'beforefieldinit'.
		static Cursor()
		{
			Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
			Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665973);
			Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665974);
			Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665975);
			Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665976);
			Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665977);
			Cursor.set_lockStateDelegateField = IL2CPP.ResolveICall<Cursor.set_lockStateDelegate>("UnityEngine.Cursor::set_lockState");
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0005F714 File Offset: 0x0005D914
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 657909, RefRangeEnd = 657913, XrefRangeStart = 657907, XrefRangeEnd = 657909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotspot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0005F768 File Offset: 0x0005D968
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x0005F798 File Offset: 0x0005D998
		public unsafe static bool visible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 657915, RefRangeEnd = 657916, XrefRangeStart = 657913, XrefRangeEnd = 657915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 657918, RefRangeEnd = 657924, XrefRangeStart = 657916, XrefRangeEnd = 657918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0005F7CC File Offset: 0x0005D9CC
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00007EE1 File Offset: 0x000060E1
		public unsafe static CursorLockMode lockState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 657926, RefRangeEnd = 657929, XrefRangeStart = 657924, XrefRangeEnd = 657926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Cursor.set_lockStateDelegateField(value);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0005F7FC File Offset: 0x0005D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657929, XrefRangeEnd = 657931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hotspot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cursorMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00007EC8 File Offset: 0x000060C8
		public Cursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00007ED1 File Offset: 0x000060D1
		public static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			Cursor.SetCursor(texture, Vector2.zero, cursorMode);
		}

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_Texture2D_byref_Vector2_CursorMode_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly Cursor.set_lockStateDelegate set_lockStateDelegateField;

		// Token: 0x020006DD RID: 1757
		// (Invoke) Token: 0x06003699 RID: 13977
		private delegate void set_lockStateDelegate(CursorLockMode value);
	}
}
