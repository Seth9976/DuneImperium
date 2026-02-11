using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Playables
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class PlayableAsset : ScriptableObject
	{
		// Token: 0x06002996 RID: 10646 RVA: 0x000AC418 File Offset: 0x000AA618
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableAsset()
		{
			Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr);
			PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668539);
			PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668540);
			PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668541);
			PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668542);
			PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668543);
			PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100668544);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000AC4C0 File Offset: 0x000AA6C0
		[CallerCount(0)]
		public unsafe virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000AC528 File Offset: 0x000AA728
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685736, XrefRangeEnd = 685740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x000AC570 File Offset: 0x000AA770
		public unsafe virtual IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685740, XrefRangeEnd = 685744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000AC5BC File Offset: 0x000AA7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685744, XrefRangeEnd = 685756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000AC620 File Offset: 0x000AA820
		[CallerCount(0)]
		public unsafe static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptrToDouble;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000AC664 File Offset: 0x000AA864
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000101F0 File Offset: 0x0000E3F0
		public PlayableAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
