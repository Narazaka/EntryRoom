# Entry Room

入場時に個別の部屋にいったんスポーンさせるシステム

## Install

### VCC用インストーラーunitypackageによる方法（おすすめ）

https://github.com/Narazaka/EntryRoom/releases/latest から `net.narazaka.vrchat.entry-room-installer.zip` をダウンロードして解凍し、対象のプロジェクトにインポートする。

### VCCによる方法

1. https://vpm.narazaka.net/ から「Add to VCC」ボタンを押してリポジトリをVCCにインストールします。
2. VCCでSettings→Packages→Installed Repositoriesの一覧中で「Narazaka VPM Listing」にチェックが付いていることを確認します。
3. アバタープロジェクトの「Manage Project」から「Entry Room」をインストールします。

## Usage

Packages/Fade Teleport/FadeTeleporterプレハブをどこかに1つだけ置いてください。

EntryRoomプレハブを置いて

- 「Regenerate Rooms」と「Setup」をこの順番で押す
- FadeTeleportToオブジェクトに
  - FadeTeleporterプレハブを指定する
  - メインエリアへのジャンプ先を指定する
- チェック機構を置かない場合はGimmickRoot/Succeedをオンにする
- チェック機構を置く場合はGimmickRoot/Guardとかに置いて位置を調整する
  - よくあるクイズとか置くやつ
  - チェックが成功したらGimmickRoot/OnSucceedをActiveにする処理をしてください

### 注意: Occlusion Cullingの暴発

原点から遠い場所にEntryRoomがある場合（デフォルト）、Occlusion Cullingの精度が悪くなり、変なカリングが為されてしまうことがあります。

この場合位置を原点に寄せるか、Area Partition GeneratorのBoundsを大きく調整してからもう一回「Regenerate Rooms」と「Setup」をし、その状態でOcclusion Cullingをベイクするなどで改善することがあります。

## License

[Zlib License](LICENSE.txt)
