using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public static class TerrainCallbacks : Object
	{
		// Token: 0x0600007B RID: 123 RVA: 0x0000417C File Offset: 0x0000237C
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainCallbacks()
		{
			Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "TerrainCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr);
			TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "heightmapChanged");
			TerrainCallbacks.NativeFieldInfoPtr_textureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "textureChanged");
			TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663303);
			TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000041FC File Offset: 0x000023FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268436, XrefRangeEnd = 1268442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004250 File Offset: 0x00002450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268442, XrefRangeEnd = 1268448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002672 File Offset: 0x00000872
		public TerrainCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000042B4 File Offset: 0x000024B4
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe static TerrainCallbacks.HeightmapChangedCallback heightmapChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.HeightmapChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000042DC File Offset: 0x000024DC
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000268D File Offset: 0x0000088D
		public unsafe static TerrainCallbacks.TextureChangedCallback textureChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.TextureChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000269F File Offset: 0x0000089F
		public static void add_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000026AC File Offset: 0x000008AC
		public static void remove_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000026B9 File Offset: 0x000008B9
		public static void add_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000026C6 File Offset: 0x000008C6
		public static void remove_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_heightmapChanged;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_textureChanged;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0;

		// Token: 0x02000071 RID: 113
		public sealed class HeightmapChangedCallback : MulticastDelegate
		{
			// Token: 0x0600029C RID: 668 RVA: 0x000035B1 File Offset: 0x000017B1
			// Note: this type is marked as 'beforefieldinit'.
			static HeightmapChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "HeightmapChangedCallback");
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663305);
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663306);
			}

			// Token: 0x0600029D RID: 669 RVA: 0x00007100 File Offset: 0x00005300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268428, XrefRangeEnd = 1268432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeightmapChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029E RID: 670 RVA: 0x0000715C File Offset: 0x0000535C
			[CallerCount(0)]
			public unsafe void Invoke(Terrain terrain, RectInt heightRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029F RID: 671 RVA: 0x000035EF File Offset: 0x000017EF
			public HeightmapChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x000035F8 File Offset: 0x000017F8
			public static implicit operator TerrainCallbacks.HeightmapChangedCallback(Action<Terrain, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.HeightmapChangedCallback>(A_0);
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x00003600 File Offset: 0x00001800
			public static TerrainCallbacks.HeightmapChangedCallback operator +(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.HeightmapChangedCallback>();
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000360E File Offset: 0x0000180E
			public static TerrainCallbacks.HeightmapChangedCallback operator -(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.HeightmapChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0;
		}

		// Token: 0x02000072 RID: 114
		public sealed class TextureChangedCallback : MulticastDelegate
		{
			// Token: 0x060002A3 RID: 675 RVA: 0x0000361F File Offset: 0x0000181F
			// Note: this type is marked as 'beforefieldinit'.
			static TextureChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "TextureChangedCallback");
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663307);
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663308);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x000071BC File Offset: 0x000053BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268432, XrefRangeEnd = 1268436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x00007218 File Offset: 0x00005418
			[CallerCount(0)]
			public unsafe void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000365D File Offset: 0x0000185D
			public TextureChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00003666 File Offset: 0x00001866
			public static implicit operator TerrainCallbacks.TextureChangedCallback(Action<Terrain, string, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.TextureChangedCallback>(A_0);
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x0000366E File Offset: 0x0000186E
			public static TerrainCallbacks.TextureChangedCallback operator +(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.TextureChangedCallback>();
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x0000367C File Offset: 0x0000187C
			public static TerrainCallbacks.TextureChangedCallback operator -(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.TextureChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0;
		}
	}
}
