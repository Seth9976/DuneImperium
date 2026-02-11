using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000015 RID: 21
	public class ComponentSingleton<T> : MonoBehaviour where T : ComponentSingleton<T>
	{
		// Token: 0x06000162 RID: 354 RVA: 0x0000A7DC File Offset: 0x000089DC
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentSingleton()
		{
			Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "ComponentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr);
			ComponentSingleton<T>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, "s_Instance");
			ComponentSingleton<T>.NativeMethodInfoPtr_get_Exists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663566);
			ComponentSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663567);
			ComponentSingleton<T>.NativeMethodInfoPtr_FindInstance_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663568);
			ComponentSingleton<T>.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663569);
			ComponentSingleton<T>.NativeMethodInfoPtr_CreateNewSingleton_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663570);
			ComponentSingleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663571);
			ComponentSingleton<T>.NativeMethodInfoPtr_DestroySingleton_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663572);
			ComponentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr, 100663573);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public unsafe static bool Exists
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1138228, RefRangeEnd = 1138236, XrefRangeStart = 1138222, XrefRangeEnd = 1138228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_get_Exists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000A92C File Offset: 0x00008B2C
		public unsafe static T Instance
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1138273, RefRangeEnd = 1138293, XrefRangeStart = 1138236, XrefRangeEnd = 1138273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000A95C File Offset: 0x00008B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138293, XrefRangeEnd = 1138298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_FindInstance_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000A98C File Offset: 0x00008B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138298, XrefRangeEnd = 1138303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComponentSingleton<T>.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138303, XrefRangeEnd = 1138320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateNewSingleton()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_CreateNewSingleton_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000AA00 File Offset: 0x00008C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138320, XrefRangeEnd = 1138348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000AA34 File Offset: 0x00008C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138364, RefRangeEnd = 1138366, XrefRangeStart = 1138348, XrefRangeEnd = 1138364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroySingleton()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr_DestroySingleton_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000AA5C File Offset: 0x00008C5C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComponentSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000293E File Offset: 0x00000B3E
		public ComponentSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000AA98 File Offset: 0x00008C98
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000AABC File Offset: 0x00008CBC
		public unsafe static T s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComponentSingleton<T>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_Instance = ComponentSingleton<T>.NativeFieldInfoPtr_s_Instance;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_Instance, (void*)(&ptr2));
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Static_get_Boolean_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_FindInstance_Private_Static_T_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_New_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewSingleton_Private_Static_T_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_DestroySingleton_Public_Static_Void_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
