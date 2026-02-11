using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	public sealed class Gizmos : Object
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x0002F1B0 File Offset: 0x0002D3B0
		// Note: this type is marked as 'beforefieldinit'.
		static Gizmos()
		{
			Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gizmos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
			Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664238);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664239);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664240);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664241);
			Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664242);
			Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664243);
			Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664244);
			Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664245);
			Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664246);
			Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664247);
			Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664248);
			Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664249);
			Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664250);
			Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664251);
			Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664252);
			Gizmos.DrawLineStripDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineStripDelegate>("UnityEngine.Gizmos::DrawLineStrip");
			Gizmos.DrawLineListDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineListDelegate>("UnityEngine.Gizmos::DrawLineList");
			Gizmos.get_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.get_exposureDelegate>("UnityEngine.Gizmos::get_exposure");
			Gizmos.set_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.set_exposureDelegate>("UnityEngine.Gizmos::set_exposure");
			Gizmos.get_probeSizeDelegateField = IL2CPP.ResolveICall<Gizmos.get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
			Gizmos.DrawCube_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawCube_InjectedDelegate>("UnityEngine.Gizmos::DrawCube_Injected");
			Gizmos.DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawMesh_Injected");
			Gizmos.DrawWireMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawWireMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawWireMesh_Injected");
			Gizmos.DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
			Gizmos.get_color_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_color_InjectedDelegate>("UnityEngine.Gizmos::get_color_Injected");
			Gizmos.get_matrix_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_matrix_InjectedDelegate>("UnityEngine.Gizmos::get_matrix_Injected");
			Gizmos.DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 649128, RefRangeEnd = 649190, XrefRangeStart = 649126, XrefRangeEnd = 649128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0002F400 File Offset: 0x0002D600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649192, RefRangeEnd = 649193, XrefRangeStart = 649190, XrefRangeEnd = 649192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere(Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0002F440 File Offset: 0x0002D640
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 649195, RefRangeEnd = 649201, XrefRangeStart = 649193, XrefRangeEnd = 649195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere(Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0002F480 File Offset: 0x0002D680
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 649203, RefRangeEnd = 649214, XrefRangeStart = 649201, XrefRangeEnd = 649203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649216, RefRangeEnd = 649218, XrefRangeStart = 649214, XrefRangeEnd = 649216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowScaling;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0002F808 File Offset: 0x0002DA08
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0002F520 File Offset: 0x0002D720
		public unsafe static Color color
		{
			get
			{
				Color color;
				Gizmos.get_color_Injected(out color);
				return color;
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 649220, RefRangeEnd = 649244, XrefRangeStart = 649218, XrefRangeEnd = 649220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002F820 File Offset: 0x0002DA20
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0002F554 File Offset: 0x0002D754
		public unsafe static Matrix4x4 matrix
		{
			get
			{
				Matrix4x4 matrix4x;
				Gizmos.get_matrix_Injected(out matrix4x);
				return matrix4x;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 649246, RefRangeEnd = 649256, XrefRangeStart = 649244, XrefRangeEnd = 649246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0002F588 File Offset: 0x0002D788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649258, RefRangeEnd = 649259, XrefRangeStart = 649256, XrefRangeEnd = 649258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 from, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649259, XrefRangeEnd = 649261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0002F608 File Offset: 0x0002D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649261, XrefRangeEnd = 649263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0002F648 File Offset: 0x0002D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649263, XrefRangeEnd = 649265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphere_Injected(ref Vector3 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0002F688 File Offset: 0x0002D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649265, XrefRangeEnd = 649267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649267, XrefRangeEnd = 649269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowScaling;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0002F728 File Offset: 0x0002D928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649269, XrefRangeEnd = 649271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0002F75C File Offset: 0x0002D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649271, XrefRangeEnd = 649273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_matrix_Injected(ref Matrix4x4 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00004CF5 File Offset: 0x00002EF5
		public Gizmos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00004CFE File Offset: 0x00002EFE
		public unsafe static void DrawLineStrip(Vector3* points, int count, bool looped)
		{
			Gizmos.DrawLineStripDelegateField(points, count, looped);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002F790 File Offset: 0x0002D990
		public unsafe static void DrawLineStrip(ReadOnlySpan<Vector3> points, bool looped)
		{
			fixed (Vector3* pinnableReference = points.GetPinnableReference())
			{
				Vector3* ptr = pinnableReference;
				Gizmos.DrawLineStrip(ptr, points.Length, looped);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00004D0D File Offset: 0x00002F0D
		public unsafe static void DrawLineList(Vector3* points, int count)
		{
			Gizmos.DrawLineListDelegateField(points, count);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		public unsafe static void DrawLineList(ReadOnlySpan<Vector3> points)
		{
			bool flag = (points.Length & 1) != 0;
			if (flag)
			{
				throw new UnityException("You cannot draw a line list from an odd number of points, with two points per line the number of points must be even");
			}
			fixed (Vector3* pinnableReference = points.GetPinnableReference())
			{
				Vector3* ptr = pinnableReference;
				Gizmos.DrawLineList(ptr, points.Length);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00004D1B File Offset: 0x00002F1B
		public static void DrawCube(Vector3 center, Vector3 size)
		{
			Gizmos.DrawCube_Injected(ref center, ref size);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00004D26 File Offset: 0x00002F26
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00004D35 File Offset: 0x00002F35
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00004D44 File Offset: 0x00002F44
		public static void DrawIcon(Vector3 center, string name, bool allowScaling)
		{
			Gizmos.DrawIcon(center, name, allowScaling, Color.white);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00004D55 File Offset: 0x00002F55
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_Injected(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0002F838 File Offset: 0x0002DA38
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00004D67 File Offset: 0x00002F67
		public static Texture exposure
		{
			get
			{
				IntPtr intPtr = Gizmos.get_exposureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				Gizmos.set_exposureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00004D79 File Offset: 0x00002F79
		public static float probeSize
		{
			get
			{
				return Gizmos.get_probeSizeDelegateField();
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00004D85 File Offset: 0x00002F85
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00004D93 File Offset: 0x00002F93
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002F860 File Offset: 0x0002DA60
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002F880 File Offset: 0x0002DA80
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		public static void DrawMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, zero, identity, one);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00004DB6 File Offset: 0x00002FB6
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0002F8D0 File Offset: 0x0002DAD0
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002F918 File Offset: 0x0002DB18
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002F944 File Offset: 0x0002DB44
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002F964 File Offset: 0x0002DB64
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002F988 File Offset: 0x0002DB88
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00004DC4 File Offset: 0x00002FC4
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0002F9FC File Offset: 0x0002DBFC
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002FA28 File Offset: 0x0002DC28
		public static void DrawIcon(Vector3 center, string name)
		{
			bool flag = true;
			Gizmos.DrawIcon(center, name, flag);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002FA44 File Offset: 0x0002DC44
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, material);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00004DD2 File Offset: 0x00002FD2
		public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002FA60 File Offset: 0x0002DC60
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			Gizmos.DrawCube_InjectedDelegateField(ref center, ref size);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00004E07 File Offset: 0x00003007
		public static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawWireMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00004E1E File Offset: 0x0000301E
		public static void DrawGUITexture_Injected(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), leftBorder, rightBorder, topBorder, bottomBorder, IL2CPP.Il2CppObjectBaseToPtr(mat));
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00004E3E File Offset: 0x0000303E
		public static void get_color_Injected(out Color ret)
		{
			Gizmos.get_color_InjectedDelegateField(out ret);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00004E4B File Offset: 0x0000304B
		public static void get_matrix_Injected(out Matrix4x4 ret)
		{
			Gizmos.get_matrix_InjectedDelegateField(out ret);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00004E58 File Offset: 0x00003058
		public static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_InjectedDelegateField(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_String_Boolean_byref_Color_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x0400064E RID: 1614
		private static readonly Gizmos.DrawLineStripDelegate DrawLineStripDelegateField;

		// Token: 0x0400064F RID: 1615
		private static readonly Gizmos.DrawLineListDelegate DrawLineListDelegateField;

		// Token: 0x04000650 RID: 1616
		private static readonly Gizmos.get_exposureDelegate get_exposureDelegateField;

		// Token: 0x04000651 RID: 1617
		private static readonly Gizmos.set_exposureDelegate set_exposureDelegateField;

		// Token: 0x04000652 RID: 1618
		private static readonly Gizmos.get_probeSizeDelegate get_probeSizeDelegateField;

		// Token: 0x04000653 RID: 1619
		private static readonly Gizmos.DrawCube_InjectedDelegate DrawCube_InjectedDelegateField;

		// Token: 0x04000654 RID: 1620
		private static readonly Gizmos.DrawMesh_InjectedDelegate DrawMesh_InjectedDelegateField;

		// Token: 0x04000655 RID: 1621
		private static readonly Gizmos.DrawWireMesh_InjectedDelegate DrawWireMesh_InjectedDelegateField;

		// Token: 0x04000656 RID: 1622
		private static readonly Gizmos.DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;

		// Token: 0x04000657 RID: 1623
		private static readonly Gizmos.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000658 RID: 1624
		private static readonly Gizmos.get_matrix_InjectedDelegate get_matrix_InjectedDelegateField;

		// Token: 0x04000659 RID: 1625
		private static readonly Gizmos.DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;

		// Token: 0x020004AE RID: 1198
		// (Invoke) Token: 0x06003263 RID: 12899
		private delegate void DrawLineStripDelegate(IntPtr points, int count, bool looped);

		// Token: 0x020004AF RID: 1199
		// (Invoke) Token: 0x06003265 RID: 12901
		private delegate void DrawLineListDelegate(IntPtr points, int count);

		// Token: 0x020004B0 RID: 1200
		// (Invoke) Token: 0x06003267 RID: 12903
		private delegate IntPtr get_exposureDelegate();

		// Token: 0x020004B1 RID: 1201
		// (Invoke) Token: 0x06003269 RID: 12905
		private delegate void set_exposureDelegate(IntPtr value);

		// Token: 0x020004B2 RID: 1202
		// (Invoke) Token: 0x0600326B RID: 12907
		private delegate float get_probeSizeDelegate();

		// Token: 0x020004B3 RID: 1203
		// (Invoke) Token: 0x0600326D RID: 12909
		private delegate void DrawCube_InjectedDelegate(IntPtr center, IntPtr size);

		// Token: 0x020004B4 RID: 1204
		// (Invoke) Token: 0x0600326F RID: 12911
		private delegate void DrawMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x020004B5 RID: 1205
		// (Invoke) Token: 0x06003271 RID: 12913
		private delegate void DrawWireMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x020004B6 RID: 1206
		// (Invoke) Token: 0x06003273 RID: 12915
		private delegate void DrawGUITexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, IntPtr mat);

		// Token: 0x020004B7 RID: 1207
		// (Invoke) Token: 0x06003275 RID: 12917
		private delegate void get_color_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004B8 RID: 1208
		// (Invoke) Token: 0x06003277 RID: 12919
		private delegate void get_matrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020004B9 RID: 1209
		// (Invoke) Token: 0x06003279 RID: 12921
		private delegate void DrawFrustum_InjectedDelegate(IntPtr center, float fov, float maxRange, float minRange, float aspect);
	}
}
