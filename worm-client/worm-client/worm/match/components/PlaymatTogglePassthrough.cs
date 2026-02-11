using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001B9 RID: 441
	public class PlaymatTogglePassthrough<T> : MonoBehaviour where T : class
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x00053390 File Offset: 0x00051590
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatTogglePassthrough()
		{
			Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "PlaymatTogglePassthrough`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr);
			PlaymatTogglePassthrough<T>.NativeFieldInfoPtr_toggleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, "toggleManager");
			PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_get_ToggleManager_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, 100665964);
			PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, 100665965);
			PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, 100665966);
			PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, 100665967);
			PlaymatTogglePassthrough<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr, 100665968);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00053474 File Offset: 0x00051674
		public unsafe T ToggleManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_get_ToggleManager_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000534B0 File Offset: 0x000516B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713083, XrefRangeEnd = 713102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000534E4 File Offset: 0x000516E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00053520 File Offset: 0x00051720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713102, XrefRangeEnd = 713106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatTogglePassthrough<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00053554 File Offset: 0x00051754
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatTogglePassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatTogglePassthrough<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatTogglePassthrough<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0000C0CD File Offset: 0x0000A2CD
		public PlaymatTogglePassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00053590 File Offset: 0x00051790
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x000535B8 File Offset: 0x000517B8
		public unsafe T toggleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatTogglePassthrough<T>.NativeFieldInfoPtr_toggleManager);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatTogglePassthrough<T>.NativeFieldInfoPtr_toggleManager);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_toggleManager;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_get_ToggleManager_Protected_get_T_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
